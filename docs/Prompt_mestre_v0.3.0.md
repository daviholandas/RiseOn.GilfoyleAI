# Prompt Mestre: Projeto Gilfoyle AI
- **version:** 0.3.0
- **status:** Em Planejamento
- **data:** 20/09/2025
- **autores:** Davi Holanda

## 1. Persona e Objetivo
... (sem alterações)

## 2. Contexto do Projeto: O Plano Mestre

### **Fase 1: Concepção e Planejamento Estratégico**
... (seções 1.1 e 1.2 sem alterações)

#### **1.3. Levantar Requisitos Não-Funcionais (Atualizado)**
- **1.3.1. Segurança:** ... (sem alterações)
- **1.3.2. Observabilidade:** A ser provida nativamente pelo **.NET Aspire**, que integra **OpenTelemetry** para logs, métricas e traces de forma padronizada.
- **1.3.3. Configurabilidade:** ... (sem alterações)

### **Fase 2: Design Técnico e Escolhas**

#### **2.1. Definir a Arquitetura (Definido)**
- **Núcleo de Orquestração:** O projeto será construído em torno do **Microsoft Semantic Kernel**.
- ... (resto da seção sem alterações)

#### **2.2. Definir a Stack Tecnológica (Definido)**
- **Plataforma Principal:** **.NET 9**.
- **Framework de Orquestração de Aplicação:** **.NET Aspire (latest version)**. Proverá a estrutura do projeto (AppHost, ServiceDefaults), orquestração de componentes (containers, serviços) e a base de observabilidade.
- **Motor de Orquestração de IA:** **Microsoft Semantic Kernel**.

#### **2.3. Planejar a Infraestrutura e Deploy**
- **Execução Local:** Gerenciada pelo **.NET Aspire AppHost**.
- **Deploy Futuro:** O manifesto de output do Aspire facilitará o deploy para ambientes como Azure Container Apps ou Kubernetes.

## 3. Como Interagir com este Prompt
... (sem alterações)

## 4. Changelog
- **v0.3.0 (20/09/2025):**
  - **Revisão da Stack:** Adotado o **.NET 9** e **.NET Aspire** como a fundação do projeto.
  - O requisito de Observabilidade agora é atendido nativamente pelo Aspire.
  - Atualizada a estratégia de execução local e deploy futuro.
- **v0.2.0 (20/09/2025):**
  - Decisão Arquitetural Chave: Adotado o Microsoft Semantic Kernel como o núcleo de orquestração.
- ... (changelog anterior)