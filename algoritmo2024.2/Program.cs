Console.WriteLine ("Digite a nota1:");
int nota1 = int.Parse(Console.ReadLine());

Console.WriteLine ("Digite a nota2:");
int nota2 = int.Parse(Console.ReadLine());

Console.WriteLine ("Digite a nota3:");
int nota3 = int.Parse(Console.ReadLine());

Console.WriteLine ("Digite a nota4:");
int nota4 = int.Parse(Console.ReadLine());

float media = (2*nota1 + 2*nota2 + 3*nota3 + 3*nota4)/10f;
Console.WriteLine("Média da disciplina: "+ media);
    
if(media >= 60){
    Console.WriteLine("aprovado");
    return;
}
else if(media < 20){
    Console.WriteLine("reprovado");
    return;
}
else{
    Console.WriteLine("recuperação");
    float previsao = 120 - media;
    Console.WriteLine($"precisa tirar {previsao} para passar");
}

Console.WriteLine("Digite o valor da prova final:");
int provaFinal = int.Parse(Console.ReadLine());

float mediaFinal = (media + provaFinal) / 2f;
Console.WriteLine("média final: " + mediaFinal);

if(mediaFinal >= 60){
    Console.WriteLine("aprovado");
}
else{
    Console.WriteLine("reprovado");
}

float mediaFinal = (media + provaFinal) / 2f;
mediaFinal = (float)Math.Round(mediaFinal);
Console.WritLine("média final: " + mediaFinal);





