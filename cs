#!/usr/bin/env bash

################################################################################
# AUTOR: Victor Dias Marques                                                   #
# CONTATO: victordmarx@pm.me                                                   #
# DATA: 27/09/2025                                                             #
# DESCRIÇÃO: Gera um arquivo com o cabeçalho pronto                            #
################################################################################
# VERSÃO: v1.0.0                                                               #
# HISTÓRICO:                                                                   #
#   1.0.0: 27/09/2025 - Versão inicial                                         #
################################################################################

if [ -z "$1" ]; then
    echo "É preciso informar 2 parâmetros: primeiro o diretório, depois o nome do arquivo que deseja criar. Separe os parâmetros por espaço."
    exit 1
elif [ ! -d "$1" ]; then
    echo "$1 não é um diretório válido"
    exit 1
fi

if [ -z "$2" ]; then
    echo "É preciso informar o nome do arquivo que deseja criar."
    exit 1

else
    cd "$1"
    echo "#!/usr/bin/env bash" >> "$2"
    echo "" >> "$2"
    echo "################################################################################" >> "$2"
    echo "# AUTOR: Victor Dias Marques                                                   #" >> "$2"
    echo "# CONTATO: victordmarx@pm.me                                                   #" >> "$2"    
    echo "# DATA: $(date +%d/%m/%Y)                                                             #" >> "$2"
    echo "# DESCRIÇÃO:                                                                   #" >> "$2"
    echo "################################################################################" >> "$2"
    echo "# VERSÃO: v1.0.0                                                               #" >> "$2"
    echo "# HISTÓRICO:                                                                   #" >> "$2"
    echo "#   1.0.0 - $(date +%d/%m/%Y) - Versão inicial                                          #" >> "$2"
    echo "################################################################################" >> "$2"
fi
    
