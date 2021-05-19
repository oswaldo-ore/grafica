using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace grafica.objetos
{
    public class Cubo
    {
        float widthC,heigthC,widthZC;
        Vector3 cm = new Vector3(0,0,0);
        
        public Cubo(float widthC,float heigthC,float widthZC){
            this.widthC = widthC;
            this.heigthC = heigthC;
            this.widthZC = widthZC;
        }
        public Cubo(float widthC,float heigthC,float widthZC,Vector3 centroMasa){
            this.widthC = widthC;
            this.heigthC = heigthC;
            this.widthZC = widthZC;
            this.cm = centroMasa;
        }

        public Vector3 centrDeMasa{

            get{ return this.cm; }
            set { this.cm = value ;}
        }

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

        public void paint(){
            float medioX = this.widthC/2,medioY=this.heigthC/2,medioZ=this.widthZC/2;
            caraDelantera(medioX,medioY,medioZ);
            caraTrasera(medioX,medioY,medioZ);
            caraLadoIzquierdo(medioX,medioY,medioZ);
            caraLadoDerecho(medioX,medioY,medioZ);
            caraArriba(medioX,medioY,medioZ);
            caraAbajo(medioX,medioY,medioZ);

        }

    }
}