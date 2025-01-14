using System.Collections;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Biblioteca
{
    public static class GestorArquivos
    {
        /// <summary>
        /// Salva os dados serializados para um arquivo JSON.
        /// </summary>
        /// <typeparam name="T">Tipo dos dados a serem salvos.</typeparam>
        /// <param name="dados">Dados a serem salvos.</param>
        /// <param name="caminhoArquivo">Caminho do arquivo JSON.</param>
        public static void SalvarDados<T>(T dados, string caminhoArquivo)
        {
            var json = JsonConvert.SerializeObject(dados, Formatting.Indented);
            File.WriteAllText(caminhoArquivo, json);
        }

        /// <summary>
        /// Carrega os dados deserializados de um arquivo JSON.
        /// </summary>
        /// <typeparam name="T">Tipo dos dados a serem carregados.</typeparam>
        /// <param name="caminhoArquivo">Caminho do arquivo JSON.</param>
        /// <returns>Os dados carregados do arquivo.</returns>
        public static T CarregarDados<T>(string caminhoArquivo)
        {
            // Verifica se o arquivo não existe
            if (!File.Exists(caminhoArquivo))
            {
                // Retorna null ou valor padrão para tipos de valor
                return default(T);
            }

            // Lê todo o conteúdo do arquivo JSON
            var json = File.ReadAllText(caminhoArquivo);

            // Verifica se o tipo T é uma lista genérica
            if (typeof(T).IsGenericType && typeof(T).GetGenericTypeDefinition() == typeof(List<>))
            {
                var objetoTipo = typeof(T).GetGenericArguments()[0];

                // Verifica se o JSON começa com "[" indicando uma lista de objetos
                if (json.TrimStart().StartsWith("["))
                {
                    // Deserializa a lista de objetos para o tipo T (List<T>)
                    return JsonConvert.DeserializeObject<T>(json, new JsonSerializerSettings
                    {
                        TypeNameHandling = TypeNameHandling.Auto,
                        NullValueHandling = NullValueHandling.Ignore,
                        PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                        Formatting = Formatting.Indented
                    });
                }
                else
                {
                    // Se o JSON não começa com "[", deserializa o único objeto para o tipo T
                    var objeto = JsonConvert.DeserializeObject(json, objetoTipo);

                    // Cria uma nova lista do tipo T e adiciona o objeto deserializado
                    var lista = (IList)Activator.CreateInstance(typeof(T));
                    lista.Add(objeto);

                    // Converte a lista para o tipo T e retorna
                    return (T)lista;
                }
            }
            else
            {
                // Se não for uma lista genérica, deserializa o JSON diretamente para o tipo T
                return JsonConvert.DeserializeObject<T>(json, new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Auto,
                    NullValueHandling = NullValueHandling.Ignore,
                    PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                    Formatting = Formatting.Indented
                });
            }
        }
    }
}
