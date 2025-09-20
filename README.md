# Gilfoyle AI

> A specialized AI Agent orchestration platform for software development

[![.NET](https://img.shields.io/badge/.NET-9.0-purple.svg)](https://dotnet.microsoft.com/download/dotnet/9.0)
[![Aspire](https://img.shields.io/badge/.NET%20Aspire-latest-blue.svg)](https://learn.microsoft.com/en-us/dotnet/aspire/)
[![Semantic Kernel](https://img.shields.io/badge/Semantic%20Kernel-latest-green.svg)](https://github.com/microsoft/semantic-kernel)

## 📋 About the Project

**Gilfoyle AI** is a backend platform that acts as an intelligent gateway for multiple specialized AI Agents. Inspired by the character Gilfoyle from Silicon Valley, the project centralizes and orchestrates different language models (LLMs), offering a single entry point to interact with an on-demand "team" of AI specialists.

### 🎯 Purpose

Transform fragmented interaction with various AI tools into a cohesive, persona-oriented experience, abstracting the complexity of multiple models and LLM providers to optimize software development workflows.

## 🏗️ Architecture

- **Main Platform:** .NET 9
- **Orchestration Framework:** .NET Aspire
- **AI Engine:** Microsoft Semantic Kernel
- **Observability:** OpenTelemetry (integrated via Aspire)

## 🚀 Version 1.0 (MVP)

### Implemented Features

- ✅ REST API for agent interaction
- ✅ Two pre-configured specialized agents:
  - **CoderAgent**: Programming specialist (Ollama + qwen3)
  - **ArchitectAgent**: Software architecture specialist (Gemini)
- ✅ Agent selection via request property
- ✅ Complete observability with traces and metrics

### Usage Example

```http
POST /api/chat
Content-Type: application/json

{
  "agent": "CoderAgent",
  "message": "How to implement a Repository pattern in C#?"
}
```

## 🔮 Roadmap (Post-V1)

### Planned Features

- **Custom Instructions (Mods)**: Allow agent personalization with persistent instructions
- **Intelligent Routing**: Automatic selection of the best LLM based on cost, speed, and quality metrics
- **User-Created Agents**: Interface for creating and configuring custom agents
- **Collaborative Agents**: Task delegation system between agents with optimized planning
- **Contextual Memory**:
  - Short-term: ChatHistory for multi-turn conversations
  - Long-term: RAG with vector database
- **MCP Exposure**: Make agents available as tools in MCP server

### Planning Strategy

The system will use a **two-LLM approach**:

- **Planner LLM**: Fast and economical model for task planning
- **Execution LLMs**: Powerful models for task execution

## 🛠️ Installation and Setup

### Prerequisites

- .NET 9 SDK
- Docker (for Ollama)
- API Keys:
  - Google Gemini API Key
  - Local Ollama configuration

### Configuration

1. Clone the repository:

```bash
git clone https://github.com/your-username/RiseOn.GilfoyleAI.git
cd RiseOn.GilfoyleAI
```

2. Configure API keys:

```bash
dotnet user-secrets set "Gemini:ApiKey" "your-gemini-key"
```

3. Run the project:

```bash
dotnet run --project src/GilfoyleAI.AppHost
```

## 📁 Project Structure

```text
RiseOn.GilfoyleAI/
├── docs/                          # Project documentation
│   ├── Projeto_Gilfoyle_AI_1.0.md # Technical conception document
│   └── Prompt_mestre_v1.0.md      # Master prompt (Single Source of Truth)
├── src/                           # Source code
│   ├── GilfoyleAI.AppHost/        # Aspire Host application
│   ├── GilfoyleAI.ApiService/     # Main REST API
│   └── GilfoyleAI.Agents/         # Agent implementations
└── README.md                      # This file
```

## 🎨 Design Principles

- **Abstraction over Concreteness**: Expose high-level concepts (Agents) and hide implementation details
- **Observability by Default**: Complete instrumentation with logs, metrics, and traces via Aspire
- **Configuration over Code**: Agent definition via configuration files
- **Simplicity for V1**: Focus on validating the main concept

## 📊 Success Criteria (V1)

- [ ] **Functional**: Complete interaction with CoderAgent via Ollama
- [ ] **Functional**: Complete interaction with ArchitectAgent via Gemini  
- [ ] **Observability**: Complete traces visible in Aspire dashboard
- [ ] **Performance**: Platform overhead < 500ms at p95

## 🤝 Contributing

This is an actively developed project. To contribute:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📝 License

This project is under the MIT license. See the `LICENSE` file for more details.

## 🙏 Acknowledgments

- Microsoft Semantic Kernel team
- .NET Aspire community
- Gilfoyle character from Silicon Valley for inspiration

---

**Version:** 1.0  
**Status:** In Development  
**Last Updated:** September 20, 2025