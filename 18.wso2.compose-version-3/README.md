#Host_Name

```CMD
1. Edite o arquivo hosts do seu windows (C:\Windows\System32\drivers\etc\hosts), adicione no final:
192.168.1.116 sid-113

2. Edite o arquivo deployment.toml (da pasta conf/apim/repository/conf)
Altere de localhost para sid-113 (30 ocorrências)
node_ip = "192.168.1.116" (1 ocorrência)

3. Edite o arquivo deployment.yaml (da pasta conf/apim-analytics-dashboard/conf/dashboard)
Altere de localhost para sid-113 (4 ocorrências)

4. Edite o arquivo deployment.yaml (da pasta conf/apim-analytics-worker/conf/worker)
Altere de localhost para sid-113 (3 ocorrências)

5. Copie via FTP para o Servidor
cd dockerfile
docker-compose up

6. Acesse no browser:
https://sid-113:9443/publisher
https://sid-113:9443/devportal
https://sid-113:9443/admin
https://sid-113:9443/carbon

7. Baixe o Integration Studio em https://wso2.com/integration/micro-integrator/

```

# Endpoint

```CMD
docker pull nodered/node-red
docker run -it -p 1880:1880 -v myNodeREDdata:/data --name mynodered nodered/node-red
docker volume ls
docker exec -it mynodered /bin/bash
npm -v

npm install --no-audit --no-update-notifier --no-fund --save --save-prefix=~ --production --engine-strict node-red-dashboard@3.0.4
npm install --no-audit --no-update-notifier --no-fund --save --save-prefix=~ --production --engine-strict node-red-node-mysql@0.2.1

exit

docker stop mynodered
docker start mynodered

Acessar no browser:
http://sid-113:1880

```
