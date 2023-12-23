# DIO - Trilha .NET - Programação orientada a objetos
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de orientação a objetos, da trilha .NET da DIO.

## Contexto
Você é responsável por modelar um sistema que trabalha com celulares. Para isso, foi solicitado que você faça uma abstração de um celular e disponibilize maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

## Proposta
Você precisa criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. 
Você deve criar as suas classes de acordo com o diagrama abaixo:

![Diagrama classes](Imagens/diagrama.png)

## Regras e validações
1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

## Solução
O código estava pela metade, e foi dada continuidade obedecendo as regras descritas acima, para que no final, tivéssemos um programa funcional. 

# Explicando a implementação de cada classe:

**Explicação classe BaseEntity:**

Objetivo: Essa classe é uma base abstrata para outras classes do sistema.

Encapsulamento: O campo _logger é protegido (readonly) e acessado por meio de uma propriedade, promovendo encapsulamento.
Inicialização no Construtor: O _logger é inicializado no construtor, garantindo que esteja pronto para uso quando necessário.

Método getClassName: Método para obter o nome da classe, útil para mensagens de log ou debugging.

Uso de Interfaces: A classe utiliza a interface ILogger, favorecendo a abstração e a flexibilidade.

**Explicação classe ILogger:**

Objetivo: Definir uma interface para logger.

Abstração: A interface ILogger permite a implementação de diferentes loggers, favorecendo a substituição e extensão do sistema.

**Explicação classe LoggerImpl:**

Objetivo: Implementação concreta da interface ILogger.

Injeção de Dependência: A classe LoggerImpl implementa a interface ILogger, permitindo a injeção de dependência em outras classes.

Uso de Console: A implementação utiliza o Console.WriteLine, adequado para ambientes de console.

**Explicação classe Smartphone:**

Objetivo: Classe abstrata que representa um smartphone.

Herança: Smartphone herda de BaseEntity, promovendo a reutilização de código e estabelecendo uma hierarquia.

Encapsulamento: As propriedades são privadas e acessadas por meio de propriedades públicas, promovendo encapsulamento.

Construtor Parametrizado: O construtor exige informações essenciais para a criação de um smartphone, promovendo a inicialização consistente.

Uso de Logger: Utiliza a funcionalidade de logging por meio da interface ILogger.

Métodos de Ação: Ligar() e ReceberLigacao() representam comportamentos associados a um smartphone.

Método Abstrato: InstalarAplicativo é declarado como abstrato, forçando as classes derivadas a fornecerem uma implementação.

**Explicação das classes Iphone e Nokia:**

Objetivo: Classe concreta que representa um iPhone/Nokia, derivada de Smartphone.

Herança: Ambas as classes herdam de Smartphone, estendendo o comportamento básico de um smartphone.

Encapsulamento: CameraQuality é privado da classe Iphone e acessado por meio de uma propriedade pública.

Construtor Parametrizado: O construtor exige informações específicas para criar um iPhone, garantindo inicialização consistente.

Implementação de Método Abstrato: Fornecimento de implementação específica para o método abstrato InstalarAplicativo.

Uso de Logger: Continua utilizando a funcionalidade de logging por meio da interface ILogger.

Método Adicional da classe Iphone: GetCameraQuality fornece uma maneira de obter a qualidade da câmera.
