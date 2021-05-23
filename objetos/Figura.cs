using OpenTK;

namespace grafica.objetos
{
    public class Figura
    {
        private float width,heigth,depth;
        
        Vector3 cm;

        public Figura(float width,float heigth,float depth)
        {
            this.width = width;
            this.heigth = heigth;
            this.depth = depth;
        }

        public Figura(float width,float heigth,float depth, Vector3 centroMasa)
        {
            this.width = width;
            this.heigth = heigth;
            this.depth = depth;
            this.cm = centroMasa;
        }


        

        public float Width { get => width; set => width = value; }
        public float Heigth { get => heigth; set => heigth = value; }
        public float Depth { get => depth; set => depth = value; }
        public Vector3 Cm { get => cm; set => cm = value; }
    }
}