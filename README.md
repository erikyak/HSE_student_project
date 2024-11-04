# Функционал 
## Окно игры при запуске  
<img width="795" alt="Снимок экрана 2024-11-05 в 00 34 32" src="https://github.com/user-attachments/assets/b935e5e6-23d3-4906-9051-ac60f547a8eb">    

## При нажатии на на +1 увеличивается ресурс над определенной кнопкой после прохождения определенного количества времени  
<img width="764" alt="Снимок экрана 2024-11-05 в 00 37 16" src="https://github.com/user-attachments/assets/51193917-31fc-4e46-a88d-f4ae73dff000">  

4 секунды для Humans, 3 для Food, 5 для Wood, 6 для Stone, 7 для Gold  

## При нажатии на +Prod{Name} увеличивается на 1 уровень производства, забирая 5 ресурсов определенного типа  
<img width="789" alt="Снимок экрана 2024-11-05 в 00 43 07" src="https://github.com/user-attachments/assets/1e6b68bf-81ef-4e15-bce3-d69f8f0a3b79">  

Формула, по которой изменяется время получения ресурса: ProductionTime * (1 - Prod{Name}/100)  
