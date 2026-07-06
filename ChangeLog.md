Changelog - Version 1.1.0

EN
New Features (Advanced Customization)
- Mathematical Factor Control: You can now fine-tune the simulation curves directly in the mod settings!
- Added Logarithmic Factor (LOG) sliders for Noise Pollution (Default: 1.2) and Air Pollution (Default: 3.5).
- Added Parabolic Factor (SQRT) sliders for Noise and Air Pollution (Default: 1.5).
- High-Precision Tuning: The noise absorption radius control (NoiseAbsorptionRadius) now supports decimal values (0.1 steps), allowing a much finer adjustment between 1.0 and 3.0.

Calibration
- Scale Calibration: Fixed the application logic for strengths (m_AirStrength / m_NoiseStrength). The UI percentage (%) values are now properly converted to decimal units instead of acting as direct multipliers, making the curves behave in a much smoother, more realistic, and predictable way.

Performance
- Internal Optimization: Refactored internal scripts and improved code compiler/execution flow for mathematical calculations (removing redundancies).

PT
Novas Funcionalidades (Customização Avançada)
- Controle de Fatores Matemáticos: Agora você pode calibrar as curvas de simulação direto nas configurações do mod!
- Adicionados os sliders de Fator Logarítmico (LOG) para Poluição Sonora (Padrão: 1.2) e do Ar (Padrão: 3.5).
- Adicionados os sliders de Fator Parabólico (SQRT) para Poluição Sonora e do Ar (Padrão: 1.5).
- Maior Precisão nos Ajustes: O controle do raio de absorção de ruído (NoiseAbsorptionRadius) agora aceita valores decimais (passos de 0.1), permitindo um ajuste muito mais fino entre 1.0 e 3.0.

Calibração
- Calibração de Escala: Corrigida a lógica de aplicação das forças (m_AirStrength / m_NoiseStrength). Os valores da interface em porcentagem (%) agora são convertidos corretamente para unidades decimais em vez de entrarem como multiplicadores diretos, tornando o comportamento das curvas muito mais suave, realista e previsível.

Desempenho
- Otimização Interna: Refatoração de scripts e melhoria no fluxo de compilação/execução da lógica matemática (redução de redundâncias no código).