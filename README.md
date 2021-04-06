## 🔰 Onion Architecture In .Net 5
Neste projeto, vamos cobrir a arquitetura Onion no ASP.Net 5.0. Como todos sabemos, é um framework recém-lançado, foi lançado oficialmente no mês de novembro.

## 🔰 O que é a Onion Architecture? 
 
<p>
Uma grande parte do projeto usual levanta questões básicas de acoplamento estreito e divisão de interesses. 
A Onion Architecture foi informada por Jeffrey Palermo por oferecer um método superior para construir aplicações no contexto de melhor testabilidade, 
praticidade e constância. A Onion Architecture atende às dificuldades enfrentadas com arquiteturas de 3 e n camadas e dá uma resposta para problemas normais. 
As camadas se associam umas às outras utilizando as interfaces.
</p>
<img src="https://csharpcorner.azureedge.net/article/onion-architecture-in-net-5/Images/O2.png" height="300px" width="300px">

## 🔰 Camadas da arquitetura
<p>
Basicamente, ele usa o conceito de camadas, mas são diferentes das camadas de 3 e N camadas. Vamos mergulhar fundo em cada uma dessas camadas.
</p>

#### 🔹 Domain Layer
<p>
Ele existe na parte central da Onion Architecture, onde consiste em todas as entidades de domínio de aplicativo que nada mais são do que modelos de banco de dados criados pela abordagem de code first.
</p>

#### 🔹 Repository Layer
<p>
A camada de repositório atua como uma camada intermediária entre os serviços e as models e nesta camada, manteremos todas as migrações de banco de dados e o application Data context e nesta camada, 
normalmente adicionamos interfaces que consistirão em padrão de acesso a dados de leitura e gravar operações envolvendo um banco de dados.
</p>

#### 🔹 Services Layer
<p>
 Esta camada é usada para a comunicação entre a camada do Repositório e o Projeto Principal, onde consiste em APIs exponíveis. A camada de serviço também pode conter a lógica de negócios de uma entidade. Nesta camada, as interfaces de serviço são mantidas separadas de sua implementação para o acoplamento fraco e também a separação de interesses. 
</p>

#### 🔹 UI Layer
<p>
 A UI nada mais é do que um aplicativo front-end que se comunicará com esta API. 
</p>

## 💯 A solução fica assim:
<img src="https://csharpcorner.azureedge.net/article/onion-architecture-in-net-5/Images/O6.png"/>


Commands to execute

     Add-Migration 'CreateCustomerTable'
    Update-database 

