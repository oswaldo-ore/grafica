using System;
using System.Collections.Generic;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace grafica.objetos
{
    public class Mesa : Figura
    {   float grosorPata;

        public Vector3 centroMasa { get => vectorPosicion; set => vectorPosicion = value; }

        private void cargarMesa(){
            float medioX = width / 2, medioY = heigth/2, medioZ = depth /2, medioGro = grosorPata / 2;
            partesObjeto = new Dictionary<String,Figura>(){
                {"tabla" , new Parte(width,grosorPata,depth,vectorPosicion)},
                {"patatraseraizquierda" , new Parte(grosorPata,heigth,grosorPata,new Vector3(vectorPosicion.X - medioX + medioGro, vectorPosicion.Y - medioY, vectorPosicion.Z + medioZ - medioGro))} ,
                {"patatraseraderecha" , new Parte(grosorPata,heigth,grosorPata,new Vector3(vectorPosicion.X  - medioX + medioGro, vectorPosicion.Y - medioY, vectorPosicion.Z - medioZ + medioGro))},
                {"patadelanteraizquierda",new Parte(grosorPata,heigth,grosorPata,new Vector3(vectorPosicion.X  +medioX - medioGro, vectorPosicion.Y - medioY   ,vectorPosicion.Z - medioZ + medioGro))},
                {"patadelanteraderecha", new Parte(grosorPata,heigth,grosorPata,new Vector3(vectorPosicion.X +medioX - medioGro, vectorPosicion.Y - medioY , vectorPosicion.Z + medioZ - medioGro))},
            };
        }

        public Mesa(float widthM,float heigthM,float widthZM,Vector3 centroMasa){
            width = widthM;
            heigth = heigthM;
            depth = widthZM;
            vectorPosicion = centroMasa;
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
            cargarMesa();
            foreach (var figura in partesObjeto)
            {
                figura.Value.paint();
            }
        }

        public override void rotar()
        {
            throw new NotImplementedException();
        }

        public override void trasladar()
        {
            throw new NotImplementedException();
        }
    }
}