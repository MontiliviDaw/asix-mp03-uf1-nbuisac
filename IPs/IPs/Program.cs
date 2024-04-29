internal class Program {
    private static void Main(string[] args) {
        string ip, mask;
        string xarxa;

        ip = DemanaIP();
        mask = DemanaMascara();
        xarxa = AdrecaXarxa(ip, mask);
        Console.WriteLine(xarxa);
    }
    static string DemanaIP() {
        string ip;

        do {
            Console.Write("Entra una IP -> ");
            ip = Console.ReadLine();
        } while (! ValidaIP(ip));
        return ip;
    }
    static bool ValidaIP(string adrecaIP) {
        bool valida = true;
        string[] valors = adrecaIP.Split('.');
        valida = (valors.Length == 4);
        if (valida) {

        }



        return valida;
    }
    static string DemanaMascara() {
        string mascara;

        Console.Write("Entra una mascara -> ");
        mascara = Console.ReadLine();
        return mascara;
    }
    static string AdrecaXarxa(string ip, string mask) {
        string xarxa = "";
        uint ipNumerica, mascaraNumerica;
        string[] valorsIp, valorsMask;

        valorsIp = ip.Split(".");
        ipNumerica = 0;
        for(int i = 0; i < valorsIp.Length; i++) {
            ipNumerica = ipNumerica * (uint)Math.Pow(2, 8) + Convert.ToUInt32(valorsIp[i]);

        }
        
        valorsMask = mask.Split(".");
        mascaraNumerica = 0;
        for (int i = 0; i < valorsMask.Length; i++) {
            mascaraNumerica = mascaraNumerica * (uint)Math.Pow(2, 8) + Convert.ToUInt32(valorsMask[i]);

        }

        uint adrecaXarxa = ipNumerica & mascaraNumerica;
        for(int i = 0; i < 4; i++) {
            xarxa = (adrecaXarxa % 256) + "." + xarxa;
            adrecaXarxa = adrecaXarxa / 256;
        }

        return xarxa.Substring(0, xarxa.Length - 1);
    }
}