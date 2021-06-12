using System;
using System.Collections.Generic;
using OpenTK;

namespace grafica.objetos
{
    public abstract class Figura:InterfaceFigura
    {
        public float width = 10,heigth = 10,depth =10;
        public Vector3 vectorPosicion = new Vector3(0,0,-100);
        public Dictionary<String,Figura> partesObjeto = new Dictionary<String, Figura>();

        public abstract void move();

        public virtual void paint()
        {   Console.WriteLine("paint de figura!");
            foreach (var partes in partesObjeto)
            {
                partes.Value.paint();
            }
        }

        public abstract void rotar();

        public abstract void trasladar();
    }
}