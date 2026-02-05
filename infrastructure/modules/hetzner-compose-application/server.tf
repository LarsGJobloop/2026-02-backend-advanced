resource "hcloud_ssh_key" "admin_key" {
  name       = "lecture-key"
  public_key = "ssh-ed25519 AAAAC3NzaC1lZDI1NTE5AAAAIJTb0amZOk5RWZrW7dJ0+4RLS9jtfhq8bug1ym1kx61o"
}

resource "hcloud_server" "server" {
  name        = "lecture-server"
  server_type = "cx33" # AMD 4vCPU, 8GB RAM, 80 SSD
  image       = "debian-13"
  location    = "hel1" # Helsinki, Finland

  ssh_keys = [
    hcloud_ssh_key.admin_key.id
  ]
}
