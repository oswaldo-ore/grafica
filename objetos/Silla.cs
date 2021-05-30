using System;
using System.Collections.Generic;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace grafica.objetos
{
    public class Silla:Figura
    {   float grosorPata;
        
        public Silla(float widthS,float heigthS,float widthZS){
            width = widthS;
            heigth = heigthS;
            depth = widthZS;
            this.grosorPata = (float)(heigthS * 0.05);
        }
        public Silla(float widthS,float heigthS,float widthZS,Vector3 centroMasa){
            width = widthS;
            heigth = heigthS;
            depth = widthZS;
            cm = centroMasa;
            this.grosorPata = (float)(widthS * 0.05);
        }

        private void cargarSilla(){
            float medioX= width/2,medioY = heigth/2,medioZ= depth/2,medioGro = grosorPata /2;
            partesObjeto =new  Dictionary<String,Figura>(){
                {"asiento" , new Cubo(width,grosorPata,depth,this.cm)},
                {"pataIzquierdaDelantera" , new Cubo(grosorPata,heigth,grosorPata,new Vector3(this.cm.X - medioX + medioGro, this.cm.Y , this.cm.Z + medioZ - medioGro))} ,
                {"pataIzquierdaTrasera" , new Cubo(grosorPata,heigth,grosorPata,new Vector3(this.cm.X - medioX + medioGro, this.cm.Y /* + medioY*/, this.cm.Z - medioZ + medioGro))},
                {"pataDerechaDelantera",new Cubo(grosorPata,medioY,grosorPata,new Vector3(this.cm.X + medioX - medioGro, this.cm.Y - medioY / 2,this.cm.Z - medioZ + medioGro))},
                {"pataDerechaTrasera", new Cubo(grosorPata,medioY,grosorPata,new Vector3(this.cm.X + medioX - medioGro, this.cm.Y - medioY / 2, this.cm.Z + medioZ - medioGro))},
                {"tablonDeAtras", new Cubo(grosorPata,grosorPata,depth,new Vector3(this.cm.X - medioX + medioGro, this.cm.Y + medioY - medioGro, this.cm.Z))}
            };
        }
        public Vector3 centroMasa { get => cm; set => cm = value; }


        public override void move()
        {
            throw new System.NotImplementedException();
        }

        public override void paint()
        {
            GL.Color3(0.6,0.8,0.7);
            cargarSilla();
            foreach (var figura in partesObjeto)
            {
                figura.Value.paint();
            }
        }
    }
}