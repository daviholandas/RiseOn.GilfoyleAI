# Documento de Concepção Técnica: Projeto Gilfoyle AI

- **Versão:** 1.0
- **Data:** 20 de setembro de 2025
- **Status:** Concepção Aprovada
- **Desenvolvido por:** Davi Holanda

## 1. O Que é o Gilfoyle AI?

O **Gilfoyle AI** é uma plataforma de backend, concebida como um agregador e orquestrador de Agentes de IA especializados. Atuando como um gateway inteligente, ele oferece um ponto de entrada único para interagir com múltiplas personas de IA, cada uma configurada com um Modelo de Linguagem Grande (LLM) e um conjunto de instruções específicas para sua área de atuação. A plataforma abstrai a complexidade de interagir com diferentes APIs e modelos, oferecendo ao usuário final acesso a um "time" de especialistas de IA sob demanda.

## 2. Qual o Propósito?

O propósito fundamental do Gilfoyle AI é **centralizar, simplificar e potencializar** o uso de múltiplos modelos de IA no fluxo de trabalho de desenvolvimento de software. Ele visa transformar a interação fragmentada com diversas ferramentas de IA em uma experiência coesa e orientada a personas.

## 3. O Porquê (Justificativa de Construção)

Em um cenário onde a quantidade de modelos de IA e ferramentas cresce exponencialmente, surge um desafio de fragmentação. A decisão de construir uma solução customizada, em vez de adotar uma ferramenta existente, é baseada em três pilares estratégicos:

1. **Soberania no Ecossistema .NET:** Construir uma solução nativa em .NET 9, Aspire e Semantic Kernel garante integração perfeita, manutenibilidade e aproveitamento máximo do conhecimento e das ferramentas do ecossistema Microsoft.
2. **Customização e Controle Total:** A plataforma será moldada exatamente para as necessidades do seu fluxo de trabalho, sem as limitações de uma ferramenta de prateleira.
3. **Adoção de Tecnologia de Ponta:** O projeto se posiciona na vanguarda, utilizando a combinação poderosa do .NET Aspire para orquestração de serviços e observabilidade, e do Microsoft Semantic Kernel para orquestração de IA de alto nível.

## 4. Arquitetura e Stack Tecnológica

O Gilfoyle AI será desenvolvido sobre uma base moderna e robusta:

- **Plataforma Principal:** **.NET 9**
- **Framework de Orquestração de Aplicação:** **.NET Aspire**
- **Motor de Orquestração de IA:** **Microsoft Semantic Kernel**

## 5. Escopo da Versão 1.0

A primeira versão funcional do Gilfoyle AI se concentrará em validar o conceito central, implementando:

- Uma API principal para receber requisições.
- Dois Agentes especializados pré-definidos:
    - **`CoderAgent`**: Focado em tarefas de programação, utilizando o **Ollama (com o modelo qwen3)** como LLM base.
    - **`ArchitectAgent`**: Focado em discussões sobre arquitetura de software, utilizando o **Gemini** como LLM base.
- Um mecanismo de seleção de agente via API.

## 6. Visão de Futuro

Após a validação do V1, a plataforma tem um caminho claro para evolução:

- **Criação de Agentes pelo Usuário:** Permitir que usuários criem e salvem suas próprias personas de agentes.
- **Agentes Colaborativos:** Implementar a capacidade de um agente delegar subtarefas para outros.
- **Exposição via MCP:** Padronizar a comunicação para que seus agentes possam ser expostos como `tools` em um servidor MCP.

## 7. Princípios de Design

- **Abstração sobre Concretude:** A plataforma deve sempre expor conceitos de alto nível (Agentes) e esconder detalhes de implementação (LLMs).
- **Observabilidade por Padrão:** Aproveitar ao máximo os recursos do .NET Aspire para garantir que toda nova funcionalidade seja instrumentada com logs, métricas e traces desde o início.
- **Configuração sobre Código:** A definição de novos agentes e suas configurações deve ser feita por meio de arquivos de configuração, visando a V2.
- **Simplicidade para o V1:** Evitar otimização prematura. O foco do V1 é validar o fluxo principal com o mínimo de componentes possível.

## 8. Riscos e Mitigações

- **Risco Técnico:** A stack (.NET 9, Aspire, SK) é muito nova, podendo apresentar bugs ou falta de documentação.
    - **Mitigação:** Focar em casos de uso bem documentados e construir Provas de Conceito (PoCs) para funcionalidades complexas.
- **Risco de Dependência:** A performance e disponibilidade dos LLMs (Gemini, etc.) estão fora do nosso controle.
    - **Mitigação:** Implementar timeouts adequados e, em uma V2, uma estratégia de fallback.
- **Risco de Custo:** O uso de APIs de nuvem (Gemini) pode gerar custos inesperados.
    - **Mitigação:** Implementar logging detalhado do consumo de tokens e configurar alertas de orçamento na plataforma de nuvem.

## 9. Critérios de Sucesso para o V1

- **Funcional:** Um usuário consegue enviar um prompt para o `CoderAgent` e receber uma resposta gerada pelo Ollama.
- **Funcional:** Um usuário consegue enviar um prompt para o `ArchitectAgent` e receber uma resposta gerada pelo Gemini.
- **Observabilidade:** Uma requisição completa pode ser visualizada no dashboard do Aspire, mostrando o trace da `ApiService` até a chamada ao LLM.
- **Performance:** O overhead da plataforma (sem contar o tempo de resposta do LLM) não deve exceder 500ms no p95.