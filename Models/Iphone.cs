namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria, string cameraQuality) : base(numero, modelo, imei, memoria) 
        {

            if (string.IsNullOrWhiteSpace(cameraQuality))
            {
                throw new ArgumentException("A qualidade da câmera não pode ser nula ou vazia.");
            }
            
            CameraQuality = cameraQuality;
        }

        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }


        public string CameraQuality { get; private set; }

        public override void InstalarAplicativo(string nomeApp)
        {
            _logger.WriteLine($"Installing app for Iphone: {nomeApp}");
        }

    }
}