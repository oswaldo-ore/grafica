using System;
using grafica.objetos;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace grafica
{
    public class Game : GameWindow
    {
        double theta = 0.0;
        public Game(int width, int heigth,string title) : base(width,heigth,GraphicsMode.Default,title){

        }

        protected override void OnLoad(EventArgs e)
        {
            GL.ClearColor(0.3f,0.2f,0.3f,1.0f);
            base.OnLoad(e);
        }
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.LoadIdentity();
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Rotate(theta,10.0,10.0,0.0);
            Silla silla = new Silla(15,30,15);
            silla.centrDeMasa = new Vector3(0,0,0);
            silla.paint();
     
            Context.SwapBuffers();
            base.OnRenderFrame(e);
            theta+=0.3;
            if(theta > 360){
                theta -=360 ;
            }
        }
        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0,0,Width,Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            //Matrix4 matrix = Matrix4.CreatePerspectiveFieldOfView(MathHelper.DegreesToRadians(45.0f),(float)(Width/Height),0.01f,300.0f);
            //GL.LoadMatrix(ref matrix);
            GL.Ortho(-100,100,-100,100,-100f,100.0f);
            GL.MatrixMode(MatrixMode.Modelview);
            
            base.OnResize(e);
            
        }
    }
}