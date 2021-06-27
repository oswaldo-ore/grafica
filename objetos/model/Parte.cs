using System.Collections.Generic;
using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace grafica.objetos
{
    public class Parte:Figura
    {               
        Vector3 puntoOriginal;
        public Parte(float widthC,float heigthC,float widthZC){
            width = widthC;
            heigth = heigthC;
            depth = widthZC;
        }

        public Parte(float widthC,float heigthC,float widthZC,Vector3 vectorPos){
            width = widthC;
            heigth = heigthC;
            depth = widthZC;
            vectorPosicion = vectorPos;
            //centroMasa = vectorPosicion;
            puntoOriginal = vectorPos;
        }
        public Parte(float widthC,float heigthC,float widthZC,Vector3 vectorPos, Vector3 cmasa){
            width = widthC;
            heigth = heigthC;
            depth = widthZC;
            vectorPosicion = vectorPos;
            puntoOriginal = vectorPos;
            //centroMasa = new Vector4(cmasa,1);
        }

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


        public override void paint()
        {  
            cargar();
        }

        public override void trasladar(float x,float y , float z){
            Matrix4 transform = Matrix4.CreateTranslation(x,y,z);
            Vector4 initial =  new Vector4(vectorPosicion,1);
            initial*=transform;
            vectorPosicion = initial.Xyz;
        }
        public override void rotar(float angle, float enElEjex, float enElEjey, float enElEjez){
            Console.WriteLine(angle);
                //angulo += MathHelper.DegreesToRadians(angle);
                angulo+=angle;
                Console.WriteLine(angulo);
                vRotate = new Vector3(enElEjex,enElEjey,enElEjez);
        }
        public override void escalar(float sentido, float ancho, float alto,float profundidad)
        {   
            Console.WriteLine(sentido + " ancho: " + ancho + " alto: "+ alto + " depth: " + profundidad);
            
            //Matrix4 scalar = Matrix4.CreateScale(ancho,alto,profundidad);
            //vectorPosicion = new Vector4(puntoOriginal,1) * scalar;
            vEscala = new Vector3(ancho,alto,profundidad);
            Console.WriteLine(vectorPosicion);
            Console.WriteLine(vEscala);
        }

        public void cargar()
        {   float medioX = width/2, medioY = heigth/2, medioZ = depth/2;
            GL.Color4(System.Drawing.Color.Green);
            GL.PushMatrix();
            //GL.Translate(vectorPosicion);
            GL.Rotate(angulo,vRotate.X,vRotate.Y,vRotate.Z);
            GL.Scale(vEscala);
            caraDelantera(medioX,medioY,medioZ);
            caraTrasera(medioX,medioY,medioZ);
            caraLadoIzquierdo(medioX,medioY,medioZ);
            caraLadoDerecho(medioX,medioY,medioZ);
            caraArriba(medioX,medioY,medioZ);
            caraAbajo(medioX,medioY,medioZ);
            GL.PopMatrix();
        }
    }
}