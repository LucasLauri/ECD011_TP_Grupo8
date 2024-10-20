Este repositório é o resultado da atividade realizada para o trabalho prático da disciplina ECD011 - Entrega Contínua e DevOps do Curso de Especialização em Engenharia de Software para Aplicações de Ciências de Dados 2024 realizado pelos alunos **Matheus de Matos Pereira**, **Dieine Estela Bernieri Schiavon de Andrade** e **Lucas de Assis Lauri** (Grupo 8). 

Como o intuito do trabalho é a implementação de um processo de integração contínua, neste trabalho uma aplicação simples para Windows usando C# (.NET) foi realizada utilizando o Visual Studio, a aplicação desenvolvida é uma calculadora simples com as funções de adição, subtração, divisão e multiplicação entre dois números, sendo um deles o resultado atual como pode ser visto na imagem a seguir.

![image](https://github.com/user-attachments/assets/0e64da87-49e2-4720-b81b-61850abf86ef)

Os _commits_ realizados para ter-se um exemplo de aplicação podem ser vistos na figura a seguir.

![image](https://github.com/user-attachments/assets/3cdccb09-7080-4e34-8f1a-98c5e7d3e698)

O diagrama de classe da aplicação desenvolvida é apresentado a seguir. Nele tem-se a classe abstrata "MathOperation" que define os atributos "Symbol" (_string_, simbolo da operação matemática) e "Numbers" (_List<double>_ números que serão utilizados na operação) e, por fim, o método _Run_ que será implementado nas classes "Add", "Subtract", "Multiply" e "Divide" para, respectivamente, somar, subtratir, multiplicar e dividir os números em "Numbers".

![ECD011_TP](https://github.com/user-attachments/assets/75809f3d-8ce8-4575-9615-60435710e14e)

Já o _build_ automatizado e execução de testes foi realizado com as _actions_ do GitHub. Ao realizar um _commit_, pelo Visual Studio por exemplo, o GitHub compila a aplicação executa os testes criados em "ECD011_TP_Grupo8Tests\ECD011_TP_Grupo8Tests.csproj". Os testes implementados foram os seguintes:

  1 - _AddTest_: verifica se a função de soma de dois números é executada corretamente;
  
  2 - _SubtractTest_: verifica se a função de subtração de dois números é executada corretamente;
  
  3 - _MultiplyTest_: verifica se a função de multiplicação de dois números é executada corretamente;
  
  4 - _DivideTest_: verifica se a função de divisão de dois números é executada corretamente;
  
  5 - _DivideByZeroTest_: verifica se a função de divisão com denominador zero lança uma exceção como deveria;

![image](https://github.com/user-attachments/assets/f66fbdf0-a97a-4b63-b087-58de20b0f4a5)

E, como esperado, ao forçar um erro no código, como fazer que o retorno da função de adição seja sempre -1, o _build_ no GitHub gera um erro:

![image](https://github.com/user-attachments/assets/fd40ba13-197d-48f0-b990-ea37236ad5f5)
![image](https://github.com/user-attachments/assets/c667a2a6-0f06-44cc-a34a-ef8b1b0abdd5)


Por fim, este repositório conta com dois _branchs_, o "master" como última atualização estavel e o "dev" para possíveis melhorias futuras serem testadas antes de serem aplicadas ao "master".
