This is a repository for my personal site and it also has some class libraries which run on the site.

To run the docker file and to host the site, run the commands:

sudo docker build -t aspnetapp .
sudo docker run -d -p 80:80 --name myapp aspnetapp
