using System.Collections.Generic;
using OpenTK;

namespace grafica.objetos
{
    public abstract class Figura:IFigura
    {
        public float width = 10,heigth = 10,depth =10;
        public Vector3 vectorPosicion = new Vector3(0,0,-100); //cambiar nombre a vector posicion
        public Dictionary<string,Figura> partesObjeto = new Dictionary<string, Figura>();

        public abstract void move();

        public abstract void paint();

        public abstract void rotar();

        public abstract void trasladar();
    }
}