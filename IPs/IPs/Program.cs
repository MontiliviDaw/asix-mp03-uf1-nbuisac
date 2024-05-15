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
            int i = 0;
            while (i < valors.Length && valida) {
                if (Convert.ToInt32(valors[i]) < 0 ||
                    Convert.ToInt32(valors[i]) > 255)
                    valida = false;
                i++;
            }
        }
        return valida;
    }
    static string DemanaMascara() {
        string mascara;

        Console.Write("Entra una mascara -> ");
        mascara = Console.ReadLine();
        while (!ValidaMascara(mascara))  {
            Console.Write("Entra una mascara -> ");
            mascara = Console.ReadLine();
        };
        return mascara;
    }
    static bool ValidaMascara(string mascara) {
        bool valida = true;
        bool totZeros = false;
        int[] llista = new int[9];
        string[] valors = mascara.Split('.');
        int i;
        
        valida = (valors.Length == 4);
        if (valida) {
            // Omplim la taula de 255, 254, 252, 248, 240, 224, ...0
            for (i = 0; i < llista.Length; i++)
                llista[i] = 255 - ((int)Math.Pow(2, i) - 1);
            i = 0;
            while (valida && i < valors.Length) {
                if (totZeros) {
                    valida = Convert.ToInt32(valors[i]) == 0;
                } else {
                    valida = llista.Contains(Convert.ToInt32(valors[i]));
                }
                i++;
            }
        }
        return valida;
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