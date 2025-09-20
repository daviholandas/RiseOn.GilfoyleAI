# Prompt Mestre: Projeto Gilfoyle AI

- **version:** 0.5.0
- **status:** Em Planejamento
- **data:** 20/09/2025
- **autores:** Davi Holanda

## 1. Persona e Objetivo

... (sem alterações)

## 2. Contexto do Projeto: O Plano Mestre

### **Fase 1: Concepção e Planejamento Estratégico**

#### **1.1. Consolidar a Visão do Produto (Atualizado)**

- **Missão:** Ser uma plataforma centralizadora de **Agentes de IA especializados**, abstraindo a complexidade de múltiplos modelos e provedores de LLM para otimizar o fluxo de trabalho de desenvolvimento de software.
- **Escopo do "V1" (Produto Mínimo Viável):**
  - Expor uma API que permite ao usuário interagir com Agentes pré-definidos.
  - Implementar 2 Agentes iniciais:
    - **`CoderAgent`**: Especialista em programação, utilizando o **Ollama (com o modelo qwen3)** como LLM base.
    - **`ArchitectAgent`**: Especialista em arquitetura de software, utilizando o **Gemini** como LLM base.
  - A seleção do agente será feita via uma propriedade no corpo da requisição (ex: `"agent": "CoderAgent"`).
- **Visão de Futuro (Pós-V1) (Atualizado):**
  - **Criação de Agentes pelo Usuário:** Implementar uma interface (API e/ou UI) que permita aos usuários criar, configurar e salvar seus próprios agentes, escolhendo o LLM, o prompt de sistema e as capacidades.
  - **Agentes Colaborativos:** Permitir que um agente principal possa delegar tarefas para outros agentes mais especializados (usando `Planners` do SK).
  - **Exposição como MCP Server:** O Gilfoyle AI poderá expor seus Agentes como `tools` em um servidor MCP.

... (resto do documento sem alterações)

## 4. Changelog

- **v0.5.1 (20/09/2025):**
  - Especificados os LLMs a serem usados pelos agentes do V1: `CoderAgent` usará `Ollama (qwen3)` e `ArchitectAgent` usará `Gemini`.
- **v0.5.0 (20/09/2025):**
  - **Revisão Conceitual:** O projeto passa de um "agregador de tools" para um "agregador de Agentes de IA especializados".
- ... (changelog anterior)