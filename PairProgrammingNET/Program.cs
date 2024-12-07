
//Console.WriteLine("Benchmark tool de consola para comparar el cifrado en MD5");
//Console.WriteLine("Primer argumento es el numero de iteraciones");

if (args.Count() < 1) {
    throw new ArgumentException("Primer argumento no es OPCIONAL");
}

// el primer argumento es el numero de iteraciones
var iterations = int.Parse(args[0]);

var stopwatch = System.Diagnostics.Stopwatch.StartNew();

for (var i = 0; i < iterations; i++)
{
    var input = new string('a', i);
    var hash = BenchmarkWorker.GetMd5Hash(input);
    //Console.WriteLine(hash);
}

stopwatch.Stop();

Console.WriteLine($"{stopwatch.ElapsedMilliseconds}");
//Console.WriteLine($"Tiempo total para {iterations} iteraciones: {stopwatch.ElapsedMilliseconds} ms");

public class BenchmarkWorker
{
    public static string GetMd5Hash(string input)
    {
        using (var md5 = System.Security.Cryptography.MD5.Create())
        {
            var inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            var hashBytes = md5.ComputeHash(inputBytes);

            var sb = new System.Text.StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }

            return sb.ToString();
        }
    }
}