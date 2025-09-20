# Prompt Mestre: Projeto Gilfoyle AI
- **version:** 0.4.0
- **status:** Em Planejamento
- **data:** 20/09/2025
- **autores:** Davi Holanda

## 1. Persona e Objetivo
... (sem alterações)

## 2. Contexto do Projeto: O Plano Mestre

### **Fase 1: Concepção e Planejamento Estratégico**

#### **1.1. Consolidar a Visão do Produto**
- **Missão:** ... (sem alterações)
- **Escopo do "V1" (Produto Mínimo Viável):** ... (sem alterações)
- **Visão de Futuro (Pós-V1) (Atualizado):**
  - Roteamento inteligente e automático baseado no conteúdo do prompt.
  - Gerenciamento de contexto de conversação (histórico).
  - **Evolução para arquitetura de microservices:** Cada agente de IA (Claude, Codex, etc.) será migrado para seu próprio projeto `Worker Service`, orquestrado pelo `.NET Aspire AppHost`.
  - Federação com outros servidores (Context7, MsLearn, etc.).
  - Cache de respostas para otimização de custo e latência.

... (seções 1.2 e 1.3 sem alterações)

### **Fase 2: Design Técnico e Escolhas**

#### **2.1. Definir a Arquitetura (Atualizado)**
- **Núcleo de Orquestração:** O projeto será construído em torno do **Microsoft Semantic Kernel**.
- **Modelo de Componentes (V1):** Para o V1, cada agente de IA (Ollama, Gemini) será implementado como um **`Plugin`** dentro do projeto principal `Gilfoyle.ApiService`.
- **Modelo de Componentes (Pós-V1):** A arquitetura evoluirá para um modelo distribuído onde cada agente será um `Worker Service` independente.
- **Protocolo de Comunicação:** ... (sem alterações)

#### **2.2. Definir a Stack Tecnológica (Atualizado)**
- **Plataforma Principal:** **.NET 9**.
- **Framework de Orquestração de Aplicação:** **.NET Aspire (latest version)**.
- **Componentes Aspire Utilizados (V1):**
  - **`Aspire.Hosting.Ollama`**: Para orquestração e configuração do agente Ollama.
- **Motor de Orquestração de IA:** **Microsoft Semantic Kernel**.

#### **2.3. Planejar a Infraestrutura e Deploy**
... (sem alterações)

## 3. Como Interagir com este Prompt
... (sem alterações)

## 4. Changelog
- **v0.4.0 (20/09/2025):**
  - Clarificada a visão de futuro para uma arquitetura de microservices, com cada agente como um Worker Service.
  - Especificado o uso do componente `.NET Aspire` para Ollama no V1.
  - Refinada a estratégia de implementação de componentes para V1 vs. Pós-V1.
- ... (changelog anterior)