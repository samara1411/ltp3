import re

def validar_senha(senha):
    # A senha deve ter pelo menos 8 caracteres
    # Deve conter pelo menos uma letra maiúscula
    # Deve conter pelo menos uma letra minúscula
    # Deve conter pelo menos um número
    # Deve conter pelo menos um caractere especial (por exemplo, !@#$%^&*)
    padrao = re.compile(r'^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$')
    return bool(re.match(padrao, senha))

def realizar_login():
    usuario = input("Digite o nome de usuário: ")
    senha = input("Digite a senha: ")

    if validar_senha(senha):
        print("Login bem-sucedido! Bem-vindo, {}.".format(usuario))
    else:
        print("A senha não atende aos critérios de segurança.")

if __name__ == "__main__":
    realizar_login()
