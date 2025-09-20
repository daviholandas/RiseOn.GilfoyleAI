# Prompt Mestre: Projeto Gilfoyle AI

- **version:** 0.2.0
- **status:** Em Planejamento
- **data:** 20/09/2025
- **autores:** Davi Holanda

## 1. Persona e Objetivo

... (sem alterações)

## 2. Contexto do Projeto: O Plano Mestre

... (sem alterações nas seções 1.1, 1.2, 1.3)

### **Fase 2: Design Técnico e Escolhas**

#### **2.1. Definir a Arquitetura (Definido)**

- **Núcleo de Orquestração:** O projeto será construído em torno do **Microsoft Semantic Kernel**. Ele será responsável por gerenciar a lógica de execução, o roteamento de prompts e a composição de tarefas.
- **Modelo de Componentes:** Cada agente de IA (Ollama, Gemini, etc.) será implementado como um **`Plugin`** dentro do Semantic Kernel.
- **Roteamento:** A decisão de qual `Plugin` (agente) executar será uma responsabilidade do Kernel, utilizando suas funcionalidades nativas (seja por roteadores manuais ou, futuramente, `Planners` automáticos).
- **Protocolo de Comunicação:** O **ModelContextProtocol (MCP)** será utilizado como um padrão de comunicação para interações com sistemas externos que suportem o protocolo. A comunicação via MCP será encapsulada dentro de `Plugins` específicos, utilizando o **ModelContextProtocol C# SDK**.

#### **2.2. Definir a Stack Tecnológica (Definido)**

- **Framework Principal:** **.NET 8** com **ASP.NET Core Web API**.
- **Motor de Orquestração de IA:** **Microsoft Semantic Kernel**.
- **Hospedagem Inicial:** Execução local (`dotnet run`) com suporte a container **Docker** para portabilidade.

#### **2.3. Planejar a Infraestrutura e Deploy**

- _(Pendente de discussão)_

## 3. Como Interagir com este Prompt

... (sem alterações)

## 4. Changelog

- **v0.2.0 (20/09/2025):**
  - **Decisão Arquitetural Chave:** Adotado o Microsoft Semantic Kernel como o núcleo de orquestração do projeto.
  - Definido o ModelContextProtocol C# SDK como uma ferramenta para comunicação dentro de plugins específicos.
  - Oficializada a stack tecnológica principal (.NET 8, ASP.NET Core).
- **v0.1.1 (20/09/2025):**
  - Renomeado o projeto de "MCP Server" para "Gilfoyle AI".
- **v0.1.0 (20/09/2025):**
  - Criação inicial do documento do projeto.# Prompt Mestre: Projeto Gilfoyle AI
- **version:** 0.2.0
- **status:** Em Planejamento
- **data:** 20/09/2025
- **autores:** User & Gemini

## 1. Persona e Objetivo

... (sem alterações)

## 2. Contexto do Projeto: O Plano Mestre

... (sem alterações nas seções 1.1, 1.2, 1.3)

### **Fase 2: Design Técnico e Escolhas**

#### **2.1. Definir a Arquitetura (Definido)**

- **Núcleo de Orquestração:** O projeto será construído em torno do **Microsoft Semantic Kernel**. Ele será responsável por gerenciar a lógica de execução, o roteamento de prompts e a composição de tarefas.
- **Modelo de Componentes:** Cada agente de IA (Ollama, Gemini, etc.) será implementado como um **`Plugin`** dentro do Semantic Kernel.
- **Roteamento:** A decisão de qual `Plugin` (agente) executar será uma responsabilidade do Kernel, utilizando suas funcionalidades nativas (seja por roteadores manuais ou, futuramente, `Planners` automáticos).
- **Protocolo de Comunicação:** O **ModelContextProtocol (MCP)** será utilizado como um padrão de comunicação para interações com sistemas externos que suportem o protocolo. A comunicação via MCP será encapsulada dentro de `Plugins` específicos, utilizando o **ModelContextProtocol C# SDK**.

#### **2.2. Definir a Stack Tecnológica (Definido)**

- **Framework Principal:** **.NET 8** com **ASP.NET Core Web API**.
- **Motor de Orquestração de IA:** **Microsoft Semantic Kernel**.
- **Hospedagem Inicial:** Execução local (`dotnet run`) com suporte a container **Docker** para portabilidade.

#### **2.3. Planejar a Infraestrutura e Deploy**

- _(Pendente de discussão)_

## 3. Como Interagir com este Prompt

... (sem alterações)

## 4. Changelog

- **v0.2.0 (20/09/2025):**
  - **Decisão Arquitetural Chave:** Adotado o Microsoft Semantic Kernel como o núcleo de orquestração do projeto.
  - Definido o ModelContextProtocol C# SDK como uma ferramenta para comunicação dentro de plugins específicos.
  - Oficializada a stack tecnológica principal (.NET 8, ASP.NET Core).
- **v0.1.1 (20/09/2025):**
  - Renomeado o projeto de "MCP Server" para "Gilfoyle AI".
- **v0.1.0 (20/09/2025):**
  - Criação inicial do documento do projeto.