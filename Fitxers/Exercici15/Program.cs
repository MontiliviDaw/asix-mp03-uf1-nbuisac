// See https://aka.ms/new-console-template for more information
const int CLAU = 14;
StreamReader fe;
char c, ce;
fe = new StreamReader(@"C:\asix\mp03\poema.txt");

while ( ! fe.EndOfStream ) {
    c = (char) fe.Read();
    if (c >= 'a' && c <= 'z') {
        ce = (char)((c - 'a' + CLAU) % ('z' - 'a' + 1) + 'a');
    } else if (c >= 'A' && c <= 'Z') {
        ce = (char)((c - 'A' + CLAU) % ('Z' - 'A' + 1) + 'A');
    } else ce = c;
    Console.Write(ce);
}
fe.Close();