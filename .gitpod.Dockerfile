FROM gitpod/workspace-dotnet

RUN wget https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb \
    && sudo dpkg -i packages-microsoft-prod.deb

RUN sudo apt-get update \
    && sudo apt-get install -y apt-transport-https \
    && sudo apt-get update \
    && sudo apt-get install -y dotnet-sdk-5.0 \
    && sudo rm -rf /var/lib/apt/lists/*

# installed the dotnet packages from apt command, so clear the DOTNET_ROOT environment variable. 
ENV DOTNET_ROOT=
