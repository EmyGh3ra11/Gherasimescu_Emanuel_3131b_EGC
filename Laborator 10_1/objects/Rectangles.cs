using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

using OpenTK;
using OpenTK.Audio.OpenAL;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

using OpenTK3_StandardTemplate_WinForms.helpers;

namespace OpenTK3_StandardTemplate_WinForms.objects
{
    class Rectangles
    {
        private PolygonMode currentPolygonState = PolygonMode.Fill;
        private bool visibility;
        private float size = 10.0f;
        private List<Vector3> coordsList;
        private List<Vector3> originalCoords;
        Color[] culori;
        string caleFisier = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName, "assets/cub.txt");
        private bool hasError;
        float aboluteLowerY;
        private const int FACTOR_SCALARE = 20;


        public Rectangles()
        {
            try
            {
                //aboluteLowerY = int.MaxValue;
                coordsList = LoadFromTxtFile(caleFisier);
                originalCoords = new List<Vector3>();
                InitCulori();
                for (int i = 0; i < coordsList.Count; i++)
                {
                    originalCoords.Add(coordsList[i]);
                }
                if (coordsList.Count == 0)
                {
                    //Console.WriteLine("Crearea obiectului a esuat: obiect negasit/coordonate lipsa!");
                    MessageBox.Show("No");
                    return;
                }
                visibility = false;
                hasError = false;
            }
            catch (Exception)
            {
                //Console.WriteLine("ERROR: assets file <" + caleFisier + "> is missing!!!");
                MessageBox.Show("No");
                hasError = true;
            }
        }

        public bool GetVisibility()
        {
            return visibility;
        }

        public void SetVisibility(bool _visibility)
        {
            visibility = _visibility;
        }

        public void Show()
        {
            visibility = true;
        }

        public void Hide()
        {
            visibility = false;
        }

        public void ToggleVisibility()
        {
            visibility = !visibility;
        }

        public void PolygonDrawingStyle(String style)
        {
            if (style == "line")
            {
                currentPolygonState = PolygonMode.Line;
                return;
            }

            if (style == "surface")
            {
                currentPolygonState = PolygonMode.Fill;
                return;
            }

        }

        

        public void Draw()
        {
            if (hasError == false)
            {
                GL.Begin(PrimitiveType.Triangles);
                for (int i = 0; i < coordsList.Count; i++)
                {
                    GL.Color3(culori[i]);
                    GL.Vertex3(coordsList[i]);
                }
                GL.End();
            }
        }

        private void InitCulori()
        {
            culori = new Color[coordsList.Count];
            Random rand = new Random();
            Color cul = new Color();
            for (int i = 0; i < culori.Length; i++)
            {
                if (i % 6 == 0) // fetele cubului vor avea aceeasi culoare, conditia functioneaza deoarece o fata este formata din 6 vertexuri consecutive
                    cul = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
                culori[i] = cul;
            }
        }

        private List<Vector3> LoadFromTxtFile(string fname)
        {
            List<Vector3> vlc3 = new List<Vector3>();


            var lines = File.ReadLines(fname);
            foreach (var line in lines)
            {
                if (line.Trim().Length > 2)
                {
                    string ch1 = line.Trim().Substring(0, 1);
                    string ch2 = line.Trim().Substring(1, 1);
                    if (ch1 == "v" && ch2 == " ")
                    {

                        string[] block = line.Trim().Split(' ');
                        if (block.Length == 4)
                        {
                            float xval = float.Parse(block[1].Trim()) * FACTOR_SCALARE;
                            float yval = float.Parse(block[2].Trim()) * FACTOR_SCALARE;
                            float zval = float.Parse(block[3].Trim()) * FACTOR_SCALARE;
                            //aboluteLowerY = Math.Min(aboluteLowerY, (int)yval); 

                            vlc3.Add(new Vector3((int)xval, (int)yval, (int)zval));
                        }
                    }
                }
            }
            return vlc3;
        }

        public void Move(float x, float y, float z)
        {
            if (aboluteLowerY + y >= 0)
            {
                aboluteLowerY += y;
                for (int i = 0; i < coordsList.Count; i++)
                {
                    coordsList[i] = new Vector3(x + coordsList[i].X, y + coordsList[i].Y, z + coordsList[i].Z);
                }
            }
            else
            {
                for (int i = 0; i < coordsList.Count; i++)
                {
                    coordsList[i] = new Vector3(x + coordsList[i].X, coordsList[i].Y, z + coordsList[i].Z);
                }

            }
        }

    }
}
