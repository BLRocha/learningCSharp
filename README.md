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
```c#
 {
    // syntax
    Nullable<T> VarNameNullable;
    // ou
    TYPE? VarNameNullable
 }
```
- Métodos
  - GetValueOrDefault
  - HasValue
  - Value (lança uma exceção caso não haja valor)

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
  - Uso comum: métodos que recebem parâmetros genéricos (Ex: Equals)
  
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

## Tratamento de Exceções

- No .NET, uma exceção é um objeto herdado da classe System.Exception
- Quando lançada, uma exceção é propagada na pilha de chamadas de métodos em execução,
  até que seja capturada (tratada) ou o programa seja encerrado.
  
![stack](https://1.bp.blogspot.com/-ojibsCmMTRI/XoGjqdxn0VI/AAAAAAAACRs/1yfM2vD_mdMVDRI_ndmXNuUgL6_N-P4jACLcBGAsYHQ/s1600/ExceptionHier.png)

## File, FileInfo

- Namespace System.IO
- Realiza operações com arquivos (create, copy, delete, move , open...) e
ajuda na criação de objetos FileStream.
- File
  - static members (simples, mas realiza verificação de segurança para cada operação)
  - [Libdoc File](https://msdn.microsoft.com/en-us/library/system.io.file(v=vs.110).aspx)
- FileInfo
  - instance members
  -  [Libdoc FileInfo](https://msdn.microsoft.com/en-us/library/system.io.fileinfo(v=vs.110).aspx)
  
