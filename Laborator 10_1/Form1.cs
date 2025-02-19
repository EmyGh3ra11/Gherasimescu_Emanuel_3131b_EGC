﻿using System;
using System.Drawing;
using System.Windows.Forms;

using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

using OpenTK3_StandardTemplate_WinForms.helpers;
using OpenTK3_StandardTemplate_WinForms.objects;

using MouseEventArgs = OpenTK.Input.MouseEventArgs;

namespace OpenTK3_StandardTemplate_WinForms
{
    public partial class MainForm : Form
    {
        private Axes mainAxis;
        private Rectangles re;
        private Camera cam;
        private Scene scene;
        private static float constDeplasare = 1f;

        private Point mousePosition;

        public MainForm()
        {   
            // general init
            InitializeComponent();

            // init VIEWPORT
            scene = new Scene();

            scene.GetViewport().Load += new EventHandler(this.mainViewport_Load);
            scene.GetViewport().Paint += new PaintEventHandler(this.mainViewport_Paint);
            //scene.GetViewport().MouseMove += new MouseEventHandler(this.mainViewport_MouseMove);
            scene.GetViewport().KeyDown += new KeyEventHandler(this.mainViewport_KeyDown);
            


            this.Controls.Add(scene.GetViewport());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // init RNG
            Randomizer.Init();

            // init CAMERA/EYE
            cam = new Camera(scene.GetViewport());

            // init AXES
            mainAxis = new Axes(showAxes.Checked);
            re = new Rectangles();
        }

        private void showAxes_CheckedChanged(object sender, EventArgs e)
        {
            mainAxis.SetVisibility(showAxes.Checked);

            scene.Invalidate();
        }

        private void changeBackground_Click(object sender, EventArgs e)
        {
            GL.ClearColor(Randomizer.GetRandomColor());

            scene.Invalidate();
        }

        private void resetScene_Click(object sender, EventArgs e)
        {
            showAxes.Checked = true;
            mainAxis.SetVisibility(showAxes.Checked);
            scene.Reset();
            cam.Reset();

            scene.Invalidate();
        }

        private void mainViewport_Load(object sender, EventArgs e)
        {
            scene.Reset();
        }

        private void mainViewport_MouseMove(object sender, MouseEventArgs e)
        {
            mousePosition = new Point(e.X, e.Y);
            scene.Invalidate();
        }

        private void mainViewport_Paint(object sender, PaintEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.Clear(ClearBufferMask.DepthBufferBit);

            cam.SetView();

            if (enableRotation.Checked == true)
            {
                // Doar după axa Ox.
                GL.Rotate(Math.Max(mousePosition.X, mousePosition.Y), 1, 1, 1);
            }

            // GRAPHICS PAYLOAD
            mainAxis.Draw();

            if (enableObjectRotation.Checked == true)
            {
                // Rotatie a obiectului
                GL.PushMatrix();
                GL.Rotate(Math.Max(mousePosition.X, mousePosition.Y), 1, 1, 1);
                re.Draw();
                GL.PopMatrix();
            } else
            {
                re.Draw();
            }

            scene.GetViewport().SwapBuffers();
        }

        private void mainViewport_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.W:
                    re.Move(constDeplasare,0, 0);
                    break;

                case Keys.S:
                    re.Move( -constDeplasare,0, 0);
                    break;

                case Keys.A:
                    re.Move(0, 0, constDeplasare);
                    break;

                case Keys.D:
                    re.Move(0, 0, -constDeplasare);
                    break;

                case Keys.Q:
                    re.Move(0, constDeplasare, 0);
                    break;

                case Keys.E:
                    re.Move(0, -constDeplasare, 0);
                    break;
            }
            scene.Invalidate();
        }
    }
}

