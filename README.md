# validate-password

![Desenho de Arquitetura](https://github.com/ingridmielnik/validate-password/blob/feature/documentacao/assets/DesArquitetura.png)


## Componentes AWS e as respectivas funcionalidades que serão utilizadas: 

### 1.Route 53 

Registrar o nome de domínio e criar automaticamente o serviço de DNS (convertem solicitações de nomes em endereços IP) para o domínio; 

Baixa latência (atraso na comunicação da rede) de consulta para os usuários finais; 

### 2.WAF  

Serviço que ajuda a proteger aplicações web contra ameaças comuns à segurança da web; 

Evitar fraude de invasão de conta; 

Filtrar o tráfego na web; 

### 3.Cloud Front 

Acelera distribuição de conteúdo dinâmico da web, distribui o conteúdo por meio de uma rede global de datacenters, denominados pontos de presença (solicitação é roteada para o ponto de presença com menor latência); 

Mais performático; 

### 4.Elastic Load Balancer 

Distribui automaticamente o tráfego de aplicações de entrada entre vários destinos e dispositivos virtuais em uma ou mais zonas de disponibilidade; 

Balanceamento de carga na AWS; 

### 5.Auto Scaling Group 

Escalonamento automático das instâncias de um grupo com base nas métricas de uso (CPU, memória, etc.), garantindo a capacidade de processamento necessária para a demanda atual; 

Combinado com o ELB para distribuir o tráfego entre várias instâncias, garantindo a distribuição uniforme do tráfego; 

### 6.Amazon EC3 

Instalar e configurar o software; 

Implantar a aplicação; 
