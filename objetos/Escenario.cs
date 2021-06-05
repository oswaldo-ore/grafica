using OpenTK;

namespace grafica.objetos
{
    public class Escenario : Figura
    {

        public Escenario(float widthS,float heigthS,float widthZS){
            width = widthS;
            heigth = heigthS;
            depth = widthZS;
        }
        public Escenario(float widthS,float heigthS,float widthZS,Vector3 centroMasa){
            width = widthS;
            heigth = heigthS;
            depth = widthZS;
            vectorPosicion = centroMasa;
        }

        public void add(System.String key,Figura figura){
            partesObjeto.Add(key,figura);
        }
        public override void move()
        {
            throw new System.NotImplementedException();
        }

        public override void paint()
        {
            foreach (var figura in partesObjeto)
            {
                figura.Value.paint();
            }
        }

        public override void rotar()
        {
            throw new System.NotImplementedException();
        }

        public override void trasladar()
        {
            throw new System.NotImplementedException();
        }
    }
}