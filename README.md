🌲 Árvore Absorption System (Reboot & Enhanced)

Welcome to **Árvore Absorption System**! This mod is a complete architectural rewrite and expansion of the environmental pollution mitigation system for trees in Cities: Skylines II. It allows you to dynamically control and balance how your city's green spaces filter both **Noise Pollution** and **Air Pollution** using advanced mathematical models.

---

# 📜 The Backstory & Special Thanks

This project is a spiritual successor and total rebuild inspired by the original mod *“Trees Reduce Noise Pollution”* developed by **kepler444f** (GitHub: kepler444a-f). 

### Why a new mod?
> *The original mod was an incredible milestone for the community, but it has unfortunately remained outdated and incompatible with recent game simulation pipelines and UI localization engine updates. To prevent this crucial feature from breaking permanently and to introduce massive performance upgrades, multi-language support, and Air Purification logic, I rebuilt the entire code from scratch into this brand-new, definitive system.*

A huge thank you to **kepler444f** for the original concept and foundation! 

---

# 🧠 Technical Deep Dive: The Mathematical Models

Every tree canopy in the game acts as a dynamic node in the pollution grid. Inside the settings panel, you can configure the calculation behavior independently for **Noise** and **Air** using three distinct curves:

## 1. 📐 LIN (Linear Mode)
A straightforward, constant accumulation model. Every tree provides a fixed, identical absolute value of environmental absorption, regardless of how dense the forest is. It is highly predictable and ideal for players who want immediate, aggressive results for every single tree planted.
* **Math Logic:** 
  $$P_{reduction} = \text{TreeCount} \times \left(\frac{\text{Strength Multiplier}}{10}\right)$$

## 2. 📈 LOG (Logarithmic Mode — Realistic physics)
Based on real-world acoustic and atmospheric saturation physics, this model introduces diminishing returns. The first few rows of trees block the majority of the pollution. As the woodland grows denser, the marginal utility of each additional tree decreases, simulating real-world forest saturation.
* **Math Logic:** 
  $$P_{reduction} = \log_{2}(\text{TreeCount} + 1) \times \text{Strength Multiplier}$$

## 3. 🪃 SQRT (Parabolic Mode — Square Root)
Calculates mitigation using a smooth quadratic curve (Square Root). This model sits perfectly between Linear and Logarithmic, preventing individual trees from being overpowered while maintaining a balanced, fluid scaling factor for large parks and greenbelts.
* **Math Logic:** 
  $$P_{reduction} = \sqrt{\text{TreeCount}} \times \text{Strength Multiplier}$$

---

# 🌀 Advanced Feature: Cell Bleedover (Radius Control)
The game engine normally locks pollution calculations inside isolated map grid cells. This mod introduces a **Bleedover Radius (0 to 5 cells)** slider. When activated, the absorption effect smoothly overflows into adjacent grid cells using a realistic distance falloff calculation, creating organic protective barriers.
* **Distance Weight Formula:** 
  $$\text{Weight} = 1.0 - \left(\frac{\text{Distance}}{\text{Radius Control} + 1}\right)$$

---

# 🌐 Complete Native UI & Multi-Language
The interface is hard-coded into native C# dictionaries, entirely bypassing broken HTML layout engines. Dropdowns utilize clean, universal scientific abbreviations (**LIN**, **LOG**, **SQRT**), backed by comprehensive real-time tooltips fully localized in:
* **Português (pt-BR)**
* **English (en-US)**
* **Deutsch (de-DE)**
* **Français (fr-FR)**
* **简体中文 (zh-HANS)**

---

# ⚙️ Configuration & Performance
* **Update Interval:** Adjustable slider (16 to 512 frames). Lower values are extremely accurate to changing tree ages/seasons; higher values drastically reduce CPU simulation overhead.
* **Diagnostic Logs:** Toglable Verbose Logging that pipes cleanly into the game's native **Player.log** framework without causing performance micro-stutters.

*Source code and architecture are built with high-performance C# jobs targeting Cities: Skylines II simulation framework.*

# 🌲 Árvore Absorption System (Reboot & Expandido)

Bem-vindo ao **Árvore Absorption System**! Este mod é uma reescrita arquitetônica completa e uma expansão do sistema de mitigação de poluição ambiental por árvores em Cities: Skylines II. Ele permite que você controle e equilibre dinamicamente como os espaços verdes da sua cidade filtram tanto a **Poluição Sonora (Ruído)** quanto a **Poluição do Ar**, utilizando modelos matemáticos avançados.

---

# 📜 A História por Trás & Agradecimentos Especiais

Este projeto é um sucessor espiritual e uma reconstrução total inspirada no mod original *“Trees Reduce Noise Pollution”* desenvolvido por **kepler444f** (GitHub: kepler444a-f).

### Por que um novo mod?
> *O mod original foi um marco incrível para a comunidade, mas infelizmente permaneceu desatualizado e incompatível com as atualizações recentes de simulação do jogo e do motor de localização da UI. Para evitar que essa funcionalidade crucial quebrasse permanentemente e para introduzir grandes melhorias de desempenho, suporte a vários idiomas e a lógica de Purificação do Ar, reconstruí todo o código do zero neste sistema totalmente novo e definitivo.*

Um enorme agradecimento a **kepler444f** pelo conceito original e pela fundação!

---

# 🧠 Análise Técnica: Os Modelos Matemáticos

Cada copa de árvore no jogo funciona como um nó dinâmico na grade de poluição. No painel de configurações, você pode configurar o comportamento do cálculo de forma independente para **Ruído** e **Ar** usando três curvas distintas:

## 1. 📐 Modo LIN (Linear)
Um modelo de acumulação direto e constante. Cada árvore fornece um valor absoluto idêntico de absorção ambiental, independentemente de quão densa seja a floresta. É altamente previsível e ideal para jogadores que desejam resultados imediatos e agressivos para cada árvore plantada.
* **Lógica Matemática:** 
  $$P_{redução} = \text{QuantidadeDeÁrvores} \times \left(\frac{\text{MultiplicadorDeForça}}{10}\right)$$

## 2. 📈 Modo LOG (Logarítmico — Física Real)
Baseado na física acústica e na saturação atmosférica do mundo real, este modelo introduz retornos decrescentes. As primeiras fileiras de árvores bloqueiam a maior parte da poluição. À medida que a floresta fica mais densa, a utilidade marginal de cada árvore adicional diminui, simulando a saturação de uma floresta real.
* **Lógica Matemática:** 
  $$P_{redução} = \log_{2}(\text{QuantidadeDeÁrvores} + 1) \times \text{MultiplicadorDeForça}$$

## 3. 🪃 Modo SQRT (Parabólico — Raiz Quadrada)
Calcula a mitigação usando uma curva quadrática suave (Raiz Quadrada). Este modelo fica perfeitamente entre o Linear e o Logarítmico, evitando que árvores individuais fiquem apelonas, ao mesmo tempo em que mantém um fator de escala equilibrado e fluido para grandes parques e cinturões verdes.
* **Lógica Matemática:** 
  $$P_{redução} = \sqrt{\text{QuantidadeDeÁrvores}} \times \text{MultiplicadorDeForça}$$

---

# 🌀 Recurso Avançado: Transição entre Células (Controle de Raio)
O motor do jogo normalmente tranca os cálculos de poluição dentro de células isoladas na grade do mapa. Este mod introduz um controle deslizante de **Raio de Transição (0 a 5 células)**. Quando ativado, o efeito de absorção transborda suavemente para as células vizinhas usando um cálculo de atenuação por distância realista, criando barreiras protetoras orgânicas.
* **Fórmula de Peso por Distância:** 
  $$\text{Peso} = 1.0 - \left(\frac{\text{Distância}}{\text{ControleDeRaio} + 1}\right)$$

---

# 🌐 Interface Nativa & Multi-Idioma Completo
A interface foi programada diretamente usando dicionários nativos em C#, contornando completamente os problemas do motor de renderização HTML do jogo. Os menus dropdown utilizam abreviações científicas limpas e universais (**LIN**, **LOG**, **SQRT**), apoiadas por descrições detalhadas em tempo real totalmente localizadas em:
* **Português (pt-BR)**
* **English (en-US)**
* **Deutsch (de-DE)**
* **Français (fr-FR)**
* **简体中文 (zh-HANS)**

---

# ⚙️ Configuração & Desempenho
* **Intervalo de Atualização:** Controle deslizante ajustável (16 a 512 frames). Valores mais baixos são extremamente precisos para acompanhar o crescimento ou as estações das árvores; valores mais altos reduzem drasticamente o impacto no processador (CPU).
* **Logs de Diagnóstico:** Ative o Registro Detalhado nas configurações para enviar informações diretamente para o sistema nativo do jogo (**Player.log**), sem causar travamentos ou pequenas travadas (*stuttering*) no desempenho.

*O código-fonte e a arquitetura foram desenvolvidos com jobs C# de alta performance, integrados perfeitamente ao framework de simulação do Cities: Skylines II.
