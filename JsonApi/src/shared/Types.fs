module SharedTypes.Types

type PokemonType = 
    | Normal
    | Fire
    | Water
    | Electric
    | Grass
    | Ice
    | Fighting
    | Poison
    | Ground
    | Flying
    | Psychic
    | Bug
    | Rock
    | Ghost
    | Dragon

type BriefPokemon = {
    num : string
    name : string
}

type Pokemon = {
    id : int
    num : string
    name : string
    img : string
    pokemonType : PokemonType list
    height : float
    weight : float
    weaknesses : PokemonType list
    evolutions : BriefPokemon list
}
