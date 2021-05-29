using System;
using System.Collections.Generic;
using grafica.objetos;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace grafica
{
    public class Game : GameWindow
    {   Dictionary<String,Figura> partesObjeto = new Dictionary<string, Figura>(){
                {"silla", new Silla(15,30,15,new Vector3(15,15,-100))},
                {"mesa" , new Mesa(30,20,30,new Vector3(30,20,-100))},
                {"silla1", new Silla(10,20,10)}
            };
        public Game(int width, int heigth,string title) : base(width,heigth,GraphicsMode.Default,title){
        }

        protected override void OnLoad(EventArgs e)
        {
            GL.ClearColor(0.3f,0.2f,0.3f,1.0f);
            base.OnLoad(e);
        }
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            //GL.LoadIdentity();
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            //GL.Rotate(theta,1.0,0.0,0.0);
            partesObjeto["silla"].paint();
            partesObjeto["mesa"].paint();
            partesObjeto["silla1"].paint();
            
            Context.SwapBuffers();
            base.OnRenderFrame(e);
        }
        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0,0,Width,Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            Matrix4 matrix = Matrix4.CreatePerspectiveFieldOfView(MathHelper.DegreesToRadians(90.0f),(float)(Width/Height),0.01f,300.0f);
            GL.LoadMatrix(ref matrix);
            //GL.Ortho(-100,100,-100,100,-100f,100.0f);
            GL.MatrixMode(MatrixMode.Modelview);
            base.OnResize(e);
            
        }
    }
}