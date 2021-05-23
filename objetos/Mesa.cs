using System;
using System.Collections.Generic;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace grafica.objetos
{
    public class Mesa : Figura,IFigura
    {   float grosorPata;
        List<IFigura> ObjetosMesa;
        Dictionary<String,IFigura> objects;

        public Vector3 centroMasa { get => Cm; set => Cm = value; }

        public Mesa(float widthM,float heigthM,float widthZM,Vector3 centroMasa):base(widthM,heigthM,widthZM,centroMasa){
            this.grosorPata = (float)(widthM * 0.05);
        }
        public Mesa(float widthM,float heigthM,float widthZM):base(widthM,heigthM,widthZM){
            this.grosorPata = (float)(widthM * 0.05);
        }

        private void cargarMesa(){
            float medioX = Width / 2, medioY = Heigth/2, medioZ = Depth /2, medioGro = grosorPata / 2;
            ObjetosMesa = new List<IFigura>(){
                new Cubo(Width,grosorPata,Depth,Cm), //plancha
                new Cubo(grosorPata,Heigth,grosorPata,new Vector3(Cm.X - medioX + medioGro, Cm.Y - medioY, Cm.Z + medioZ - medioGro)), //pataIzquierdaTrasera
                new Cubo(grosorPata,Heigth,grosorPata,new Vector3(Cm.X  - medioX + medioGro, Cm.Y - medioY, Cm.Z - medioZ + medioGro)), //pataDerechaTrasera
                new Cubo(grosorPata,Heigth,grosorPata,new Vector3(Cm.X  +medioX - medioGro, Cm.Y - medioY   ,Cm.Z - medioZ + medioGro)), //pataFrenteIzquierda
                new Cubo(grosorPata,Heigth,grosorPata,new Vector3(Cm.X +medioX - medioGro, Cm.Y - medioY , Cm.Z + medioZ - medioGro)), //pataFrenteDerecha
            };
            objects = new Dictionary<String,IFigura>(){
                {"tabla" , new Cubo(Width,grosorPata,Depth,Cm)},
                {"patatraseraizquierda" , new Cubo(grosorPata,Heigth,grosorPata,new Vector3(Cm.X - medioX + medioGro, Cm.Y - medioY, Cm.Z + medioZ - medioGro))} ,
                {"patatraseraderecha" , new Cubo(grosorPata,Heigth,grosorPata,new Vector3(Cm.X  - medioX + medioGro, Cm.Y - medioY, Cm.Z - medioZ + medioGro))},
                {"patadelanteraizquierda",new Cubo(grosorPata,Heigth,grosorPata,new Vector3(Cm.X  +medioX - medioGro, Cm.Y - medioY   ,Cm.Z - medioZ + medioGro))},
                {"patadelanteraderecha", new Cubo(grosorPata,Heigth,grosorPata,new Vector3(Cm.X +medioX - medioGro, Cm.Y - medioY , Cm.Z + medioZ - medioGro))},
            };
        }

        public void move()
        {
            throw new System.NotImplementedException();
        }

        

        public void paint()
        {
            GL.Color3(0.1,0.8,0.7);
            cargarMesa();
            /*for (int i = 0; i < ObjetosMesa.Count ; i++){
                ObjetosMesa[i].paint();
            }*/
            foreach (var figura in objects)
            {
                figura.Value.paint();
            }
        }
    }
}