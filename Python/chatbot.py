responses = {
    "hello":"Hello, how can I help you?",
    "how are you?": "I'm good, thank you!",
    "bye": "Goodbye!",
    "default": "I'm sorry, I didn't understand that."
}

def chatbot_response(message):
    message = message.lower()
    response = responses.get(message, responses["default"])
    return response

def main():
    print("Chatbot: Hello!!")
    while True:
        message=input("You: ")
        if message.lower() == 'bye':
            print("Chatbot: Goodbye!")
            break
        else:
            response = chatbot_response(message)
            print("Chatbot:", response)

if __name__ == "__main__":
    main()