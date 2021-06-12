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
            figura.vectorPosicion = new Vector3(
            vectorPosicion.X + figura.vectorPosicion.X,
            vectorPosicion.Y + figura.vectorPosicion.Y,
            vectorPosicion.Z + figura.vectorPosicion.Z);
            partesObjeto.Add(key,figura);
        }

        public void eliminar(string key){
            partesObjeto.Remove(key);
        }

        public Figura get(string key){
            return partesObjeto[key];
        }
        public override void move()
        {
            throw new System.NotImplementedException();
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