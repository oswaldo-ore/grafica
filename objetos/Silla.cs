using System.Globalization;
using System.Collections.Generic;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace grafica.objetos
{
    public class Silla
    {
        float widthS,heigthS,widthZS;
        Vector3 cm = new Vector3(0,0,0);
        float grosorPata;

        List<Cubo> objectosSilla;
        
        public Silla(float widthS,float heigthS,float widthZS){
            this.widthS = widthS;
            this.heigthS = heigthS;
            this.widthZS = widthZS;
            this.grosorPata = (float)(heigthS * 0.05);
        }

        private void cargarSilla(){
            float medioX= widthS/2,medioY = heigthS/2,medioZ= widthZS/2,medioGro = grosorPata /2;
            objectosSilla = new List<Cubo>(){
                new Cubo(widthS,grosorPata,widthZS,this.cm), //asiento
                new Cubo(grosorPata,heigthS,grosorPata,new Vector3(this.cm.X - medioX + medioGro, this.cm.Y /*+ medioY*/, this.cm.Z + medioZ - medioGro)), //pataIzquierdaDelantera
                new Cubo(grosorPata,heigthS,grosorPata,new Vector3(this.cm.X - medioX + medioGro, this.cm.Y /* + medioY*/, this.cm.Z - medioZ + medioGro)), //pataIzquierdaTrasera
                new Cubo(grosorPata,medioY,grosorPata,new Vector3(this.cm.X + medioX - medioGro, this.cm.Y - medioY / 2,this.cm.Z - medioZ + medioGro)), //pataDerechaDelantera
                new Cubo(grosorPata,medioY,grosorPata,new Vector3(this.cm.X + medioX - medioGro, this.cm.Y - medioY / 2, this.cm.Z + medioZ - medioGro)), //pataDerechaTrasera
                new Cubo(grosorPata,grosorPata,widthZS,new Vector3(this.cm.X - medioX + medioGro, this.cm.Y + medioY - medioGro, this.cm.Z)),
            };
        }
        public Vector3 centrDeMasa{

            get{ return this.cm; }
            set { this.cm = value ;}
        }

        public void paint(){
            GL.Color3(0.1,0.8,0.7);
            cargarSilla();
            for (int i = 0; i < objectosSilla.Count ; i++){
                objectosSilla[i].paint();
            }
        }

    }
}