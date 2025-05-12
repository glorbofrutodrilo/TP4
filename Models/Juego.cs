class Juego
{
    public static char [] palabraAAdivinar {get;private set;}
    public static int letraspalabra {get;private set;}

    public static string[] palabrasAhorcado {get;private set;}
    public static void IniciarJuego()
    {
        palabrasAhorcado = new string[]    
        {
            "abeja", "abismo", "abogado", "abono", "abrazo", "abrigo", "abrir", "abuelo", "aceite", "acera",
            "acero", "acierto", "aclarar", "acoger", "acorde", "actuar", "adicto", "adivina", "adonde", "adorno",
            "adulto", "afilar", "afinar", "afirmar", "agitar", "agotar", "agrado", "aguado", "aguja", "airear",
            "ajuste", "alado", "alarma", "albañil", "alcoba", "alegre", "aliento", "alma", "almohada", "almuerzo",
            "alondra", "altar", "altivo", "altura", "alumno", "alzar", "amable", "amado", "amante", "amargo",
            "ambos", "amenaza", "amigo", "amor", "amparo", "amplio", "andar", "andén", "anillo", "animal",
            "ánimo", "anotar", "ansioso", "antena", "antiguo", "anular", "añadir", "añejo", "apagar", "aparte",
            "apelar", "aplauso", "aplicar", "apodo", "apoyo", "aprender", "apretar", "apto", "apurar", "aquel",
            "araña", "árbol", "archivo", "arder", "ardilla", "arena", "argolla", "aroma", "arpón", "arreglo",
            "arte", "artista", "ascenso", "aseado", "asiento", "asilo", "asistir", "asno", "asomar", "aspirar",
            "asunto", "atajo", "ataque", "atención", "atento", "aterrizaje", "atleta", "atrever", "atributo", "audaz",
            "aumento", "aunado", "aurora", "autor", "aval", "avanzar", "ave", "avión", "avispa", "ayer",
            "ayuda", "azafata", "azotea", "azúcar", "bailar", "bajar", "balanza", "balón", "banda", "baño",
            "barato", "barba", "barco", "barra", "base", "bastón", "batalla", "bebé", "beca", "besar",
            "bestia", "bicho", "bien", "bingo", "bisagra", "blanco", "bloque", "boca", "bodega", "bola",
            "bolsa", "bomba", "bondad", "bonito", "borde", "bosque", "botella", "bravo", "brazo", "breve",
            "brillo", "brisa", "broma", "brota", "bruja", "bruma", "brusco", "bueno", "buitre", "bulto",
            "burla", "buscar", "caballo", "cabra", "cacao", "café", "caja", "cala", "calle", "calma",
            "calor", "calvo", "cama", "cambio", "caminar", "camión", "campo", "canal", "canción", "candelabro",
            "canino", "cansar", "cantar", "cantidad", "cañón", "capaz", "capilla", "capote", "captura", "cara",
            "caracol", "caravana", "carbono", "cardo", "cargar", "caricia", "carne", "caro", "carro", "carta",
            "casa", "casco", "casero", "casilla", "caso", "castillo", "castor", "catarro", "catre", "caudal",
            "causa", "caverna", "caviar", "cebolla", "ceder", "ceja", "celda", "célula", "cemento", "cenar",
            "ceniza", "centro", "ceñir", "cerca", "cerdo", "cereal", "cereza", "cerrar", "cerro", "certeza",
            "cesar", "cielo", "ciego", "cien", "cierre", "cifra", "cigarro", "cilindro", "cima", "cine",
            "círculo", "cisne", "cita", "clamar", "claridad", "clase", "clave", "cliente", "clima", "clonar",
            "cloro", "cobarde", "cobija", "cobre", "cobro", "cocer", "cocina", "codo", "cofre", "coger",
            "cohete", "cojín", "cola", "colcha", "colegio", "colina", "collar", "colmena", "columna", "combate",
            "comer", "cometa", "comida", "compás", "común", "concha", "conde", "conga", "conocer", "consejo",
            "contar", "convertir", "coral", "corazón", "cordero", "cordón", "corona", "correr", "corrida", "corte",
            "cortar", "cosecha", "coser", "cosmos", "costar", "costo", "crecer", "crema", "crimen", "crisis",
            "crudo", "cruz", "cuadro", "cuarta", "cubrir", "cuchara", "cueva", "cuerda", "cuervo", "cuesta",
            "cuidado", "culebra", "culpa", "cultura", "cuna", "cura", "curar", "curioso", "curso", "curva",
            "cuyo", "dama", "danza", "dar", "dato", "deber", "débil", "decir", "dedo", "defensa",
            "definir", "dejar", "delgado", "demente", "demonio", "dentista", "dentro", "deporte", "derecho", "derrota",
            "desayuno", "descanso", "deseo", "desnudo", "detalle", "detener", "día", "diablo", "diadema", "diario",
            "dibujar", "diente", "dieta", "difícil", "digno", "dilema", "dinero", "diosa", "dirección", "dirigir",
            "discoteca", "diseño", "disfraz", "distinto", "diva", "dividir", "doblar", "doctor", "documento", "dólar",
            "dolor", "domingo", "donar", "dormir", "dorso", "dragón", "duelo", "duende", "dulce", "duro"
        };
        Random rnd = new Random();
        int numeroAleatorio = rnd.Next(0, 521);
        palabraAAdivinar = palabrasAhorcado[numeroAleatorio].ToCharArray();
        letraspalabra = palabraAAdivinar.Length;
        
    }

    public static bool Gano(){
        return true;
    }

    public static bool Perdio(){
        return false;
    }
    public static bool compararLetra(char letra)
    {
        bool esta = false;
        if (palabraAAdivinar.Contains(letra)==true)
        {
            esta = true;
           
        }
        else{
            esta = false;
        }
        return esta;
    }

}