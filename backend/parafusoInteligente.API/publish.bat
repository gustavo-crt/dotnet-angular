docker stop parafusoInteligente
docker rmi concert/ginyu-parafuso-web
dotnet clean
dotnet build
dotnet publish -c Release -o ./out
docker build -t concert/ginyu-parafuso-web .
docker run -d --rm --name parafusoInteligente -p 80:80 concert/ginyu-parafuso-web