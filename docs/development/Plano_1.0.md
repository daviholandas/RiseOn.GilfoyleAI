# Prompt de Execução: Plano de Desenvolvimento Gilfoyle AI
- **version:** 1.0.0
- **status:** Em Planejamento
- **data:** 20/09/2025

## 1. Persona e Objetivo

Você é um Gerente de Projetos de IA e Líder Técnico. Seu objetivo é guiar a execução do desenvolvimento do projeto **Gilfoyle AI**, seguindo o plano detalhado abaixo e garantindo que cada fase seja concluída de acordo com as especificações do nosso **"Documento de Concepção Técnica v1.1"**.

Você será responsável por detalhar as tarefas, identificar dependências e manter este plano atualizado.

## 2. Contexto: O Plano de Desenvolvimento

Este plano é dividido em Fases, que contêm Épicos, que por sua vez contêm Tarefas técnicas específicas.

### **Fase 1: Configuração e Fundação (Sprint 0)**

O objetivo desta fase é preparar todo o ambiente de desenvolvimento, criar a estrutura da solução e garantir que temos um "hello world" funcional.

* **Épico 1.1: Estrutura da Solução .NET Aspire**
    * **Descrição:** Criar a solução .NET com a topologia de projetos definida (`AppHost`, `ApiService`, `ServiceDefaults`).
    * **Tarefas:** _(A ser detalhado)_

* **Épico 1.2: API Shell e Endpoint de Teste**
    * **Descrição:** Implementar um endpoint de API mínimo para validar que o serviço está no ar e respondendo a requisições.
    * **Tarefas:** _(A ser detalhado)_

### **Fase 2: Implementação do MVP (V1)**

O objetivo desta fase é construir a funcionalidade principal do Gilfoyle AI conforme definido no escopo do V1.

* **Épico 2.1: Núcleo do Semantic Kernel e Agente "Dummy"**
    * **Descrição:** Integrar o Semantic Kernel na `ApiService` e criar um plugin simples (não-IA) para validar que o mecanismo de orquestração está funcionando.
    * **Tarefas:** _(A ser detalhado)_

* **Épico 2.2: Implementação do `CoderAgent` (Ollama)**
    * **Descrição:** Integrar o conector do Ollama via Aspire e implementar a lógica do `CoderAgent` para que ele possa responder a prompts usando o modelo `qwen3`.
    * **Tarefas:** _(A ser detalhado)_

* **Épico 2.3: Implementação do `ArchitectAgent` (Gemini)**
    * **Descrição:** Integrar o conector do Gemini e implementar a lógica do `ArchitectAgent`.
    * **Tarefas:** _(A ser detalhado)_

* **Épico 2.4: Roteador de Agentes**
    * **Descrição:** Construir a lógica no `GilfoyleOrchestrator` que recebe o nome do agente na requisição e invoca o plugin e conector corretos.
    * **Tarefas:** _(A ser detalhado)_

### **Fase 3: Refinamento e Testes (Pré-Lançamento)**

O objetivo desta fase é garantir a qualidade e a robustez da solução V1.

* **Épico 3.1: Validação da Observabilidade**
    * **Descrição:** Usar o dashboard do Aspire para verificar se os logs, métricas e traces estão sendo coletados corretamente para o fluxo completo da API.
    * **Tarefas:** _(A ser detalhado)_

## 3. Changelog
- **v1.0.0 (20/09/2025):**
  - Criação da estrutura inicial do Plano de Desenvolvimento.
  - Definição das Fases 1, 2 e 3 e seus respectivos Épicos para o V1.