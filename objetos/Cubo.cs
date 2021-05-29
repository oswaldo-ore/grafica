using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace grafica.objetos
{
    public class Cubo:Figura
    {        
        public Cubo(float widthC,float heigthC,float widthZC){
            width = widthC;
            heigth = heigthC;
            depth = widthZC;
        }
        public Cubo(float widthC,float heigthC,float widthZC,Vector3 centroMasa){
            width = widthC;
            heigth = heigthC;
            depth = widthZC;
            cm = centroMasa;
        }

        public Vector3 CentroMasa { get => this.cm; set => this.cm = value; }

        private void caraDelantera(float medioX,float medioY,float medioZ){
            GL.Begin(PrimitiveType.Polygon);
            GL.Vertex3(cm.X - medioX, cm.Y + medioY,cm.Z +medioZ);
            GL.Vertex3(cm.X + medioX, cm.Y + medioY,cm.Z + medioZ);
            GL.Vertex3(cm.X + medioX, cm.Y - medioY,cm.Z + medioZ);
            GL.Vertex3(cm.X - medioX, cm.Y - medioY,cm.Z + medioZ);
            GL.End();
        }
        private void caraTrasera(float medioX,float medioY,float medioZ){
            GL.Begin(PrimitiveType.Polygon);
            GL.Vertex3(cm.X - medioX, cm.Y + medioY,cm.Z -medioZ);
            GL.Vertex3(cm.X + medioX, cm.Y + medioY,cm.Z - medioZ);
            GL.Vertex3(cm.X + medioX, cm.Y - medioY,cm.Z - medioZ);
            GL.Vertex3(cm.X - medioX, cm.Y - medioY,cm.Z - medioZ);

            GL.End();
        }
        private void caraLadoIzquierdo(float medioX,float medioY,float medioZ){
             GL.Begin(PrimitiveType.Polygon);
            GL.Vertex3(cm.X - medioX, cm.Y + medioY,cm.Z - medioZ);
            GL.Vertex3(cm.X - medioX, cm.Y + medioY,cm.Z + medioZ);
            GL.Vertex3(cm.X - medioX, cm.Y - medioY,cm.Z + medioZ);
            GL.Vertex3(cm.X - medioX, cm.Y - medioY,cm.Z - medioZ);
            GL.End();
        }
        private void caraLadoDerecho(float medioX,float medioY,float medioZ){
            GL.Begin(PrimitiveType.Polygon);
            GL.Vertex3(cm.X + medioX, cm.Y + medioY,cm.Z - medioZ);
            GL.Vertex3(cm.X + medioX, cm.Y + medioY,cm.Z + medioZ);
            GL.Vertex3(cm.X + medioX, cm.Y - medioY,cm.Z + medioZ);
            GL.Vertex3(cm.X + medioX, cm.Y - medioY,cm.Z - medioZ);
            GL.End();
        }

        private void caraArriba(float medioX,float medioY,float medioZ){
            GL.Begin(PrimitiveType.Polygon);
            GL.Vertex3(cm.X - medioX, cm.Y + medioY,cm.Z - medioZ);
            GL.Vertex3(cm.X + medioX, cm.Y + medioY,cm.Z - medioZ);
            GL.Vertex3(cm.X + medioX, cm.Y + medioY,cm.Z + medioZ);
            GL.Vertex3(cm.X - medioX, cm.Y + medioY,cm.Z + medioZ);
            GL.End();
        }
        private void caraAbajo(float medioX,float medioY,float medioZ){
            GL.Begin(PrimitiveType.Polygon);
            GL.Vertex3(cm.X - medioX, cm.Y - medioY,cm.Z - medioZ);
            GL.Vertex3(cm.X + medioX, cm.Y - medioY,cm.Z - medioZ);
            GL.Vertex3(cm.X + medioX, cm.Y - medioY,cm.Z + medioZ);
            GL.Vertex3(cm.X - medioX, cm.Y - medioY,cm.Z + medioZ);
            GL.End();
        }

        public override void move()
        {
            throw new System.NotImplementedException();
        }

        public override void paint()
        {
            float medioX = width/2, medioY = heigth/2, medioZ = depth/2;
            caraDelantera(medioX,medioY,medioZ);
            caraTrasera(medioX,medioY,medioZ);
            caraLadoIzquierdo(medioX,medioY,medioZ);
            caraLadoDerecho(medioX,medioY,medioZ);
            caraArriba(medioX,medioY,medioZ);
            caraAbajo(medioX,medioY,medioZ);
        }
    }
}