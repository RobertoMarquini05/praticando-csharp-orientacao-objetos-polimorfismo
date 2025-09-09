# Praticando C#: Orientação a Objetos com Polimorfismo

Este repositório contém exercícios e exemplos práticos desenvolvidos durante o curso **"C#: Orientação a Objetos com Polimorfismo"** da Alura.

O objetivo principal foi consolidar conceitos de **Programação Orientada a Objetos (POO)**, incluindo:

* Herança
* Polimorfismo
* Interfaces
* Classes abstratas

## Conteúdo

O projeto inclui exemplos de:

### 1. Calculadora

* Sobrecarga de métodos (`Somar`) para inteiros e números decimais.

### 2. Funcionários e Relatórios

* Classe base `Funcionario` com subclasses `Gerente` e `Desenvolvedor`.
* Sobrescrita de métodos para gerar relatórios diferentes.

### 3. Sistema de Notificações

* Interface `INotificacao` implementada por `EmailNotificacao`, `SmsNotificacao` e `PushNotificacao`.

### 4. Tarefas Agendadas

* Classe abstrata `TarefaAgendada` com subclasses `BackupTarefa`, `RelatorioTarefa` e `LimpezaTarefa`.

### 5. Galeria Online

* Classe base `Midia` com subclasses `Imagem` e `Video`.
* Polimorfismo aplicado ao método `ExibirDetalhes()`.

### 6. Sistema de Reservas

* Classe base `Reserva` com subclasses `ReservaPresencial` e `ReservaOnline`.

### 7. Plataforma de Cursos

* Classe base `Conteudo` com subclasses `AulaGravada` e `MaterialComplementar`.

### 8. Simulador de Transporte

* Classe base `Transporte` com subclasses `Onibus`, `Metro` e `Bicicleta`.

### 9. Simulador de Empréstimos

* Interface `IEmprestimo` implementada por `EmprestimoEstudante`, `EmprestimoEmpresario` e `EmprestimoAposentado`.

### 10. Painel Administrativo de Botões

* Interface `IAcaoBotao` implementada por `SalvarAcao`, `EditarAcao` e `ExcluirAcao`.

## Tecnologias Utilizadas

* C#
* .NET 8
* Conceitos de POO e polimorfismo

## Como Usar

1. Clone o repositório:

```bash
git clone https://github.com/SEU-USUARIO/SEU-REPOSITORIO.git
```

2. Abra no Visual Studio ou VS Code e execute os exemplos de cada exercício.

## Conclusão

Este curso ajudou a reforçar a aplicação de **polimorfismo, interfaces e classes abstratas** em cenários reais, preparando para projetos mais complexos em C#.


