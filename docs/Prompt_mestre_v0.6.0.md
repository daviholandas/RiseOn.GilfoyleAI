# Prompt Mestre: Projeto Gilfoyle AI
- **version:** 0.6.0
- **status:** Em Planejamento
- **data:** 20/09/2025
- **autores:** Davi Holanda

## 1. Persona e Objetivo
... (sem alterações)

## 2. Contexto do Projeto: O Plano Mestre

### **Fase 1: Concepção e Planejamento Estratégico**

#### **1.1. Consolidar a Visão do Produto**
- **Missão:** ... (sem alterações)
- **Escopo do "V1":** ... (sem alterações)
- **Visão de Futuro (Pós-V1) (Atualizado):**
  - **Criação de Agentes pelo Usuário:** ... (sem alterações)
  - **Agentes Colaborativos com Planejamento Otimizado:** Permitir que um agente principal possa delegar tarefas para outros agentes, utilizando os `Planners` do Semantic Kernel. A estratégia de planejamento adotará um padrão de dois LLMs: um modelo mais rápido e de baixo custo será usado exclusivamente para a tarefa de **planejamento**, enquanto modelos mais poderosos e de alta qualidade serão usados para a **execução** das tarefas.
  - **Exposição como MCP Server:** ... (sem alterações)

... (seções 1.2 e 1.3 sem alterações)

### **Fase 2: Design Técnico e Escolhas**

#### **2.1. Definir a Arquitetura (Atualizado)**
- **Núcleo de Orquestração:** Microsoft Semantic Kernel.
- **Roteamento de Agentes:** ... (sem alterações)
- **Estratégia de Planejamento (Pós-V1):** O sistema de `Planners` será configurado para usar um LLM específico, mais leve e otimizado para raciocínio estruturado (o "Planner LLM"). As funções de execução, por sua vez, serão configuradas para usar LLMs mais poderosos e especializados (os "Execution LLMs") através do `ServiceId` nos `PromptExecutionSettings`.

#### **2.2. Definir a Stack Tecnológica (Atualizado)**
- **Plataforma Principal:** **.NET 9**.
- **Framework de Orquestração de Aplicação:** **.NET Aspire (latest version)**.
- **Componentes Aspire Utilizados (V1):**
  - **`Aspire.Hosting.Ollama`**: Para orquestração do agente `CoderAgent`.
- **Motor de Orquestração de IA:** **Microsoft Semantic Kernel**.
- **Conectores de IA:** A arquitetura suportará múltiplos conectores de IA registrados com `ServiceId` distintos para permitir a separação entre Planner LLMs e Execution LLMs.

... (resto do documento sem alterações)

## 4. Changelog
- **v0.6.0 (20/09/2025):**
  - **Adicionada Estratégia de Planejamento Otimizado:** Formalizado o conceito de usar um LLM leve e de baixo custo para as tarefas de planejamento (`Planner LLM`) e LLMs mais poderosos para as tarefas de execução (`Execution LLM`).
  - Atualizadas as seções de Visão de Futuro e Arquitetura para refletir este padrão de design.
- **v0.5.1 (20/09/2025):**
  - Especificados os LLMs a serem usados pelos agentes do V1: `CoderAgent` usará `Ollama (qwen3)` e `ArchitectAgent` usará `Gemini`.
- ... (changelog anterior)