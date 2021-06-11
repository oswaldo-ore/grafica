using System;
using System.Collections.Generic;
using grafica.objetos;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace grafica
{
    public class Game : GameWindow
    {   
        Escenario es1;
        public Game(int width, int heigth,string title) : base(width,heigth,GraphicsMode.Default,title){
            es1 = new Escenario(200,200,300,new Vector3(-30,-30,30));
            es1.add("silla",new Silla(15,30,15,new Vector3(15,15,-100)));
            es1.add("mesa" , new Mesa(30,20,30,new Vector3(30,20,-100)));
        }

        protected override void OnLoad(EventArgs e)
        {
            GL.ClearColor(0.3f,0.2f,0.3f,1.0f);
            base.OnLoad(e);
        }
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            es1.paint();
            Context.SwapBuffers();
            base.OnRenderFrame(e);
        }
        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0,0,Width,Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            Matrix4 matrix = Matrix4.CreatePerspectiveFieldOfView(MathHelper.DegreesToRadians(90.0f),(float)(Width/Height),0.1f,500.0f);
            GL.LoadMatrix(ref matrix);
            //GL.Ortho(-100,100,-100,50,100.0,-100.0f);
            GL.MatrixMode(MatrixMode.Modelview);
            base.OnResize(e);
            
        }
    }
}