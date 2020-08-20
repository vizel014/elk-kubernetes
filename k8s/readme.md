# Build Docker Image & push to Docker Hub,

docker build -t app:v1.0 .
docker tag 4a38fe95c105 vizel014/app:v1.0
docker push vizel014/app

# Run tests in Docker,

docker run -p 80:80 vizel014/app:v1.0

# Apply ELK & SimchaApp To Kubernetes Using Yaml Files,

kubectl apply -f all-in-one.yaml

# Monitor the operator logs,

kubectl -n elastic-system logs -f statefulset.apps/elastic-operator

kubectl.exe apply -f elasticsearch.yaml,
kubectl.exe apply -f kibana.yaml,
kubectl.exe apply -f filebeat.yaml,
kubectl.exe apply -f deployment.yaml,
kubectl -n kubernetes-dashboard describe secret $(kubectl -n kubernetes-dashboard get secret | grep admin-user | awk '{print $1}')
kubectl port-forward service/kibana-name-kb-http 5601

# Login to Kibana dashboard,

https://localhost:5601/app/discover

elasticsearch kubernetes.labels.app : "simchaapp" 

Aug 20, 2020 @ 14:53:28.617	Info:LogSuccessful 08/20/2020 11:53:28
Aug 20, 2020 @ 14:53:23.614	Info:LogSuccessful 08/20/2020 11:53:23
Aug 20, 2020 @ 14:53:18.626	Info:LogSuccessful 08/20/2020 11:53:18
