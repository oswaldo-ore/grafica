using System;
using System.Collections.Generic;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace grafica.objetos
{
    public class Mesa : Figura
    {   float grosorPata;

        public Vector3 centroMasa { get => cm; set => cm = value; }

        private void cargarMesa(){
            float medioX = width / 2, medioY = heigth/2, medioZ = depth /2, medioGro = grosorPata / 2;
            partesObjeto = new Dictionary<String,Figura>(){
                {"tabla" , new Cubo(width,grosorPata,depth,cm)},
                {"patatraseraizquierda" , new Cubo(grosorPata,heigth,grosorPata,new Vector3(cm.X - medioX + medioGro, cm.Y - medioY, cm.Z + medioZ - medioGro))} ,
                {"patatraseraderecha" , new Cubo(grosorPata,heigth,grosorPata,new Vector3(cm.X  - medioX + medioGro, cm.Y - medioY, cm.Z - medioZ + medioGro))},
                {"patadelanteraizquierda",new Cubo(grosorPata,heigth,grosorPata,new Vector3(cm.X  +medioX - medioGro, cm.Y - medioY   ,cm.Z - medioZ + medioGro))},
                {"patadelanteraderecha", new Cubo(grosorPata,heigth,grosorPata,new Vector3(cm.X +medioX - medioGro, cm.Y - medioY , cm.Z + medioZ - medioGro))},
            };
        }

        public Mesa(float widthM,float heigthM,float widthZM,Vector3 centroMasa){
            width = widthM;
            heigth = heigthM;
            depth = widthZM;
            cm = centroMasa;
            this.grosorPata = (float)(widthM * 0.05);
        }

        public Mesa(float widthM, float heigthM, float widthZM){
            width = widthM;
            heigth = heigthM;
            depth = widthZM;
            this.grosorPata = (float)(widthM * 0.05);
        }


        public override void move()
        {
            throw new NotImplementedException();
        }

        public override void paint()
        {
            GL.Color3(0.1,0.8,0.7);
            cargarMesa();
            foreach (var figura in partesObjeto)
            {
                figura.Value.paint();
            }
        }
    }
}