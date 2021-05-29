using OpenTK;

namespace grafica.objetos
{
    public abstract class Figura:IFigura
    {
        public float width,heigth,depth;
        public Vector3 cm = new Vector3(0,0,0);

        public abstract void move();

        public abstract void paint();
    }
}