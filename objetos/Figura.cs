using System;
using System.Collections.Generic;
using OpenTK;

namespace grafica.objetos
{
    public abstract class Figura:IFigura
    {
        public float width = 10,heigth = 10,depth =10;
        public Vector3 cm = new Vector3(0,0,-100);
        public Dictionary<String,Figura> partesObjeto;

        public abstract void move();

        public abstract void paint();
    }
}