# Prompt de Execução: Plano de Desenvolvimento Gilfoyle AI

- **version:** 2.0.0
- **status:** Planejamento Detalhado
- **data:** 20/09/2025

## 1. Persona e Objetivo

... (sem alterações)

## 2. Contexto: O Plano de Desenvolvimento

Este plano é dividido em Fases, que contêm Épicos, que por sua vez contêm Tarefas técnicas específicas.

### **Fase 1: Configuração e Fundação (Sprint 0)**

... (Considerado concluído pelo desenvolvedor)

### **Fase 2: Implementação do MVP (V1)**

O objetivo desta fase é construir a funcionalidade principal do Gilfoyle AI conforme definido no escopo do V1.

- **Épico 2.1: Núcleo do Semantic Kernel e Agente "Dummy"**
  - **Descrição:** Integrar o Semantic Kernel na `ApiService` e criar um plugin simples (não-IA) para validar que o mecanismo de orquestração está funcionando de ponta a ponta.
  - **Tarefas (Já detalhadas):**
    - **2.1.1:** Adicionar pacotes NuGet do `Microsoft.SemanticKernel`.
    - **2.1.2:** Registrar serviços do SK com `AddKernel()`.
    - **2.1.3:** Criar o `DummyPlugin.cs` com a função `Echo`.
    - **2.1.4:** Criar a interface `IOrchestrator` e a classe `GilfoyleOrchestrator`.
    - **2.1.5:** Implementar o construtor do `GilfoyleOrchestrator` para carregar o `DummyPlugin`.
    - **2.1.6:** Implementar o método `ExecuteAsync` no orquestrador.
    - **2.1.7:** Modificar o endpoint da API para usar o `IOrchestrator`.
    - **2.1.8:** **Critério de Aceitação:** Validar o fluxo completo com o `DummyPlugin`.

- **Épico 2.2: Implementação do `CoderAgent` (Ollama)**
  - **Descrição:** Integrar o conector do Ollama via Aspire e implementar a lógica do `CoderAgent` para que ele possa responder a prompts usando o modelo `qwen3`.
  - **Tarefas:**
    - **2.2.1:** Adicionar o pacote NuGet `Aspire.Hosting.Ollama` ao projeto `Gilfoyle.AppHost`.
    - **2.2.2:** No `AppHost/Program.cs`, registrar o recurso Ollama (`builder.AddOllama(...)`) e referenciá-lo na `ApiService` (`.WithReference(...)`).
    - **2.2.3:** Adicionar o pacote NuGet `Microsoft.SemanticKernel.Connectors.Ollama` ao projeto `Gilfoyle.ApiService`.
    - **2.2.4:** No `ApiService/Program.cs`, registrar o conector do Ollama (`.AddOllamaChatCompletion()`) com um `serviceId` único, como `"ollama_coder"`.
    - **2.2.5:** Criar a estrutura de pastas para o plugin semântico: `/Plugins/CoderAgent/Ask`.
    - **2.2.6:** Dentro da pasta, criar o `skprompt.txt` com o prompt de sistema do `CoderAgent` (ex: "Você é um programador especialista. Sua tarefa é escrever código limpo, eficiente e bem documentado...").
    - **2.2.7:** Criar o `config.json`, especificando o `service_id: "ollama_coder"` para garantir que esta função use o conector correto.
    - **2.2.8:** **Critério de Aceitação:** Testar (via um endpoint temporário ou teste unitário) a invocação direta do `CoderAgent_Ask` e receber uma resposta coerente do modelo `qwen3` rodando via Ollama.

- **Épico 2.3: Implementação do `ArchitectAgent` (Gemini)**
  - **Descrição:** Integrar o conector do Gemini e implementar a lógica do `ArchitectAgent`.
  - **Tarefas:**
    - **2.3.1:** Adicionar o pacote NuGet `Microsoft.SemanticKernel.Connectors.Google` ao `Gilfoyle.ApiService`.
    - **2.3.2:** Adicionar a chave da API do Gemini ao `secrets.json` do projeto `ApiService` (ex: `"Google:ApiKey": "..."`).
    - **2.3.3:** No `ApiService/Program.cs`, registrar o conector do Gemini (`.AddGoogleGeminiChatCompletion()`) com um `serviceId` único, como `"gemini_architect"`.
    - **2.3.4:** Criar a estrutura de pastas para o plugin semântico: `/Plugins/ArchitectAgent/Ask`.
    - **2.3.5:** Criar o `skprompt.txt` com o prompt de sistema do `ArchitectAgent` (ex: "Você é um arquiteto de soluções sênior. Sua tarefa é fornecer conselhos claros, estratégicos e bem fundamentados sobre arquitetura de software...").
    - **2.3.6:** Criar o `config.json`, especificando o `service_id: "gemini_architect"`.
    - **2.3.7:** **Critério de Aceitação:** Testar a invocação direta do `ArchitectAgent_Ask` e receber uma resposta coerente do Gemini.

- **Épico 2.4: Roteador de Agentes**
  - **Descrição:** Construir a lógica no `GilfoyleOrchestrator` que recebe o nome do agente na requisição e invoca o plugin e conector corretos.
  - **Tarefas:**
    - **2.4.1:** No `GilfoyleOrchestrator`, implementar a lógica para carregar todos os plugins da pasta `/Plugins` na inicialização, usando `ImportPluginFromPromptDirectory`.
    - **2.4.2:** Refatorar a API para usar o contrato final (ex: `POST /api/v1/invoke` com o corpo `{"agent": "CoderAgent", "prompt": "..."}`).
    - **2.4.3:** No `GilfoyleOrchestrator`, implementar a lógica de roteamento principal. O método receberá `"CoderAgent"` como entrada e saberá que precisa invocar a função `Ask` do plugin `CoderAgent`.
    - **2.4.4:** Remover o endpoint de teste e o `DummyPlugin` (ou desativá-los).
    - **2.4.5:** **Critério de Aceitação:** Uma requisição para a API com `"agent": "CoderAgent"` é respondida pelo Ollama.
    - **2.4.6:** **Critério de Aceitação:** Uma requisição para a API com `"agent": "ArchitectAgent"` é respondida pelo Gemini.

### **Fase 3: Refinamento e Testes (Pré-Lançamento)**

- **Épico 3.1: Validação da Observabilidade**
  - **Descrição:** Usar o dashboard do Aspire para verificar se os logs, métricas e traces estão sendo coletados corretamente para o fluxo completo da API.
  - **Tarefas:**
    - **3.1.1:** Iniciar a solução completa pelo `AppHost`.
    - **3.1.2:** Abrir o dashboard do Aspire.
    - **3.1.3:** Fazer uma chamada bem-sucedida para o `CoderAgent`. Na aba "Traces" do dashboard, verificar a existência de um trace completo (`ApiService` -> `Ollama`).
    - **3.1.4:** Fazer uma chamada bem-sucedida para o `ArchitectAgent`. Verificar o trace completo (`ApiService` -> `Gemini`).
    - **3.1.5:** Provocar um erro (ex: enviar um nome de agente inválido). Verificar se o log de erro estruturado aparece na aba "Logs" do `ApiService`.
    - **3.1.6:** **Critério de Aceitação:** Todos os fluxos principais (sucesso e erro) geram logs e traces correlacionados e visíveis no dashboard.

## 3. Changelog

- **v2.0.0 (20/09/2025):**
  - Detalhadas todas as tarefas técnicas para os Épicos das Fases 2 e 3.
  - O plano de desenvolvimento para o V1 está completo e pronto para revisão.
- ... (changelog anterior)
