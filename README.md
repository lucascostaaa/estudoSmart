# SmartDataCollector

O projeto `SmartDataCollector` é uma aplicação de console .NET que serve como uma interface para a ferramenta `smartctl` do pacote `smartmontools`, permitindo a coleta e visualização dos dados SMART (Self-Monitoring, Analysis, and Reporting Technology) de dispositivos de armazenamento como HDDs e SSDs. Desenvolvido em C#, o programa invoca `smartctl` para consultar e retornar informações detalhadas sobre a saúde e desempenho do disco especificado.

## Requisitos

Para utilizar o `SmartDataCollector`, os seguintes requisitos devem ser atendidos:

- Windows OS com .NET Framework instalado ou sistema compatível.
- `smartmontools` deve estar instalado e o caminho para o `smartctl` deve ser configurado corretamente dentro do código do programa.

## Instalação

### Windows

1. Instale o `smartmontools` a partir do [site oficial](https://www.smartmontools.org/) e anote o caminho de instalação.
2. Abra o arquivo `Program.cs` e atualize a variável `FileName` na função `GetSmartData` para o caminho onde o `smartctl.exe` está localizado, por exemplo, `C:\\Program Files\\smartmontools\\bin\\smartctl.exe`.

### Linux (Apenas para referência)

- Embora o exemplo de código esteja preparado principalmente para Windows, ajustes menores permitiriam sua execução em sistemas Linux, ajustando o caminho do executável e o identificador do dispositivo.

## Uso

Para executar o `SmartDataCollector`:

1. Compile o código usando seu ambiente de desenvolvimento .NET preferido ou a linha de comando.
2. Execute o programa compilado no terminal ou prompt de comando, o qual exibirá os dados SMART do dispositivo especificado na variável `drive`.

## Possíveis Problemas

Ao utilizar o `SmartDataCollector`, você pode se deparar com alguns problemas comuns. Aqui estão alguns dos mais frequentes e como resolvê-los:

### smartctl não encontrado

**Problema**: O programa retorna um erro indicando que não conseguiu encontrar ou executar `smartctl`.

**Solução**: Certifique-se de que o `smartmontools` esteja instalado corretamente em seu sistema e que o caminho para o `smartctl.exe` especificado no código esteja correto. No Windows, o caminho padrão após a instalação do `smartmontools` pode ser algo como `C:\\Program Files\\smartmontools\\bin\\smartctl.exe`. Verifique se o caminho reflete a localização correta do executável em seu sistema.

### Permissão Negada

**Problema**: Ao tentar executar o programa, você recebe uma mensagem de erro sobre permissões insuficientes.

**Solução**: No Windows, execute o Prompt de Comando ou o PowerShell como Administrador. No Linux, embora o código seja primariamente direcionado para o Windows, se adaptado, você pode precisar usar `sudo` para executar o programa ou garantir que o usuário tenha as permissões adequadas para acessar as informações SMART dos dispositivos.

### Dados SMART não disponíveis ou incompletos

**Problema**: Os dados SMART retornados estão incompletos, não disponíveis ou não fazem sentido.

**Solução**: Nem todos os dispositivos de armazenamento suportam todas as métricas SMART ou podem ter suporte limitado dependendo do fabricante ou modelo. Verifique a documentação do seu dispositivo para entender quais dados SMART ele suporta. Além disso, certifique-se de que o `smartmontools` está atualizado para a versão mais recente, pois atualizações podem melhorar o suporte a dispositivos específicos.

### Erro ao executar smartctl

**Problema**: O programa reporta um erro ao tentar executar o comando `smartctl`, indicando um problema com o processo de execução.

**Solução**: Verifique se as configurações de segurança do seu sistema (como o Controle de Conta de Usuário no Windows ou políticas de segurança específicas no Linux) não estão impedindo a execução de scripts ou aplicativos de linha de comando. No Windows, tentar desativar temporariamente essas configurações pode ajudar a identificar o problema.


