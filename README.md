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

## Herança em C#

1. **Definições importantes**

- Vantagens:
    - Reuso
    - Polimorfismo
    
- Sintaxe
    - `:` (estende)
    - `base` (referência para a superclasse)
    
- Upcasting
  - Casting da subclass para superclass
  - Uso comum: polimorfismo
  
- Downcasting
  - Casting da superclass para subclass
  - Palavra `as`
  - Palavra `is`
  - Uso comum: métodos que recebem parâmetros genéricos (Ex: Eqauls)
  
- Clssses e Métodos selados
  - Palavra chave: `sealed`
  - **Classe** evita que a classe seja herdada
    - Nota: ainda é possível extender a funcionalidade de uma classe selada usando `extension methods`
    ```c#
    namespace NameSpcStd {
        sealed class ClassName {
        
        } 
    }
    ```
  - **Métodos:** evita que um Método sobreposto possa ser sobresposto novamente
    - Só pode ser aplicado a métodos sobrepostos
  
