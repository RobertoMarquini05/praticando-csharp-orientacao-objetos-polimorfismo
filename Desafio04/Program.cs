using Desafio04;

List<TarefaAgendada> tarefas = new List<TarefaAgendada>
        {
            new BackupTarefa(),
            new RelatorioTarefa(),
            new LimpezaTarefa()
        };

foreach (var tarefa in tarefas)
{
    tarefa.Executar();
}

Console.ReadKey();