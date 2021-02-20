# - Anotações

### Ordem de implementação para classes.

1. Atributos Privados
1. Propriedades autoimplementadas
1. Construtores
1. Propriedade customizadas
1. Outros métodos da classe

## Construtores sintaxe alternativa

```c#
public class Construct
    {
        public string Name;
        public uint Age;
        public double Height;
    
        public Construct() {
            Name = "vazio|void";
        }
        public Construct(string name, uint age, double height) {
            Name = name;
            Age = age;
            Height = height;
        }

        public override string ToString()
        {
            return "Name: " + Name + "\n" +
                   "Age: " + Age + "\n" +
                   "Height: " + Height;
        }
    }
```
```c#
    Construct c = new Construct
    {
        Name = "Teste", Age = 78, Height = 1.75
    };

    Console.WriteLine(c);
```

## Nullable
> É um cursor de C# para que dados de tipos valor(structs) possam
receber o valor null

> Uso Comum:
>> - Campos de bamco de dados que podem ser valorado como null
>> - Dados e parâmetros opcionais.

