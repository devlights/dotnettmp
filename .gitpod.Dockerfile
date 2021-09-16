FROM gitpod/workspace-dotnet

RUN sudo apt-get update \
    && sudo apt-get install -y tree bc nkf \
    && sudo rm -rf /var/lib/apt/lists/*
