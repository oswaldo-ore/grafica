using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace grafica.objetos
{
    public class Parte:Figura
    {        
        public Parte(float widthC,float heigthC,float widthZC){
            width = widthC;
            heigth = heigthC;
            depth = widthZC;
        }
        public Parte(float widthC,float heigthC,float widthZC,Vector3 centroMasa){
            width = widthC;
            heigth = heigthC;
            depth = widthZC;
            vectorPosicion = centroMasa;
        }

        public Vector3 CentroMasa { get => vectorPosicion; set => vectorPosicion = value; }

        private void caraDelantera(float medioX,float medioY,float medioZ){
            GL.Begin(PrimitiveType.Polygon);
            GL.Vertex3(vectorPosicion.X - medioX, vectorPosicion.Y + medioY,vectorPosicion.Z +medioZ);
            GL.Vertex3(vectorPosicion.X + medioX, vectorPosicion.Y + medioY,vectorPosicion.Z + medioZ);
            GL.Vertex3(vectorPosicion.X + medioX, vectorPosicion.Y - medioY,vectorPosicion.Z + medioZ);
            GL.Vertex3(vectorPosicion.X - medioX, vectorPosicion.Y - medioY,vectorPosicion.Z + medioZ);
            GL.End();
        }
        private void caraTrasera(float medioX,float medioY,float medioZ){
            GL.Begin(PrimitiveType.Polygon);
            GL.Vertex3(vectorPosicion.X - medioX, vectorPosicion.Y + medioY,vectorPosicion.Z -medioZ);
            GL.Vertex3(vectorPosicion.X + medioX, vectorPosicion.Y + medioY,vectorPosicion.Z - medioZ);
            GL.Vertex3(vectorPosicion.X + medioX, vectorPosicion.Y - medioY,vectorPosicion.Z - medioZ);
            GL.Vertex3(vectorPosicion.X - medioX, vectorPosicion.Y - medioY,vectorPosicion.Z - medioZ);
            GL.End();
        }
        private void caraLadoIzquierdo(float medioX,float medioY,float medioZ){
             GL.Begin(PrimitiveType.Polygon);
            GL.Vertex3(vectorPosicion.X - medioX, vectorPosicion.Y + medioY,vectorPosicion.Z - medioZ);
            GL.Vertex3(vectorPosicion.X - medioX, vectorPosicion.Y + medioY,vectorPosicion.Z + medioZ);
            GL.Vertex3(vectorPosicion.X - medioX, vectorPosicion.Y - medioY,vectorPosicion.Z + medioZ);
            GL.Vertex3(vectorPosicion.X - medioX, vectorPosicion.Y - medioY,vectorPosicion.Z - medioZ);
            GL.End();
        }
        private void caraLadoDerecho(float medioX,float medioY,float medioZ){
            GL.Begin(PrimitiveType.Polygon);
            GL.Vertex3(vectorPosicion.X + medioX, vectorPosicion.Y + medioY,vectorPosicion.Z - medioZ);
            GL.Vertex3(vectorPosicion.X + medioX, vectorPosicion.Y + medioY,vectorPosicion.Z + medioZ);
            GL.Vertex3(vectorPosicion.X + medioX, vectorPosicion.Y - medioY,vectorPosicion.Z + medioZ);
            GL.Vertex3(vectorPosicion.X + medioX, vectorPosicion.Y - medioY,vectorPosicion.Z - medioZ);
            GL.End();
        }

        private void caraArriba(float medioX,float medioY,float medioZ){
            GL.Begin(PrimitiveType.Polygon);
            GL.Vertex3(vectorPosicion.X - medioX, vectorPosicion.Y + medioY,vectorPosicion.Z - medioZ);
            GL.Vertex3(vectorPosicion.X + medioX, vectorPosicion.Y + medioY,vectorPosicion.Z - medioZ);
            GL.Vertex3(vectorPosicion.X + medioX, vectorPosicion.Y + medioY,vectorPosicion.Z + medioZ);
            GL.Vertex3(vectorPosicion.X - medioX, vectorPosicion.Y + medioY,vectorPosicion.Z + medioZ);
            GL.End();
        }
        private void caraAbajo(float medioX,float medioY,float medioZ){
            GL.Begin(PrimitiveType.Polygon);
            GL.Vertex3(vectorPosicion.X - medioX, vectorPosicion.Y - medioY,vectorPosicion.Z - medioZ);
            GL.Vertex3(vectorPosicion.X + medioX, vectorPosicion.Y - medioY,vectorPosicion.Z - medioZ);
            GL.Vertex3(vectorPosicion.X + medioX, vectorPosicion.Y - medioY,vectorPosicion.Z + medioZ);
            GL.Vertex3(vectorPosicion.X - medioX, vectorPosicion.Y - medioY,vectorPosicion.Z + medioZ);
            GL.End();
        }

        public override void move()
        {
            throw new System.NotImplementedException();
        }

        public override void paint()
        {
            Console.WriteLine("paint del cubo");
            float medioX = width/2, medioY = heigth/2, medioZ = depth/2;
            caraDelantera(medioX,medioY,medioZ);
            caraTrasera(medioX,medioY,medioZ);
            caraLadoIzquierdo(medioX,medioY,medioZ);
            caraLadoDerecho(medioX,medioY,medioZ);
            caraArriba(medioX,medioY,medioZ);
            caraAbajo(medioX,medioY,medioZ);
        }

        public override void rotar()
        {
            throw new System.NotImplementedException();
        }

        public override void trasladar()
        {
            throw new System.NotImplementedException();
        }
    }
}